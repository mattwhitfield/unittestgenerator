﻿namespace Unitverse.Commands
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Design;
    using System.IO;
    using System.Linq;
    using System.Windows.Input;
    using EnvDTE;
    using EnvDTE80;
    using Microsoft.VisualStudio.Shell;
    using Unitverse.Core.Assets;
    using Unitverse.Core.Helpers;
    using Unitverse.Core.Options;
    using Unitverse.Helper;
    using Project = EnvDTE.Project;
    using Task = System.Threading.Tasks.Task;

    /// <summary>
    /// Command handler.
    /// </summary>
    internal sealed class GenerateUnitTestsCommand
    {
        /// <summary>
        /// Command ID.
        /// </summary>
        private const int CommandId = 0x0101;

        private const int RegenerateCommandId = 0x104;

        /// <summary>
        /// Command menu group (command set GUID).
        /// </summary>
        private static readonly Guid CommandSet = new Guid("63d6b7b1-4f20-4519-9f56-09f9e220fd1b");

        private static GenerateUnitTestsCommand _instance;

        private static DTE2 _dte;

        /// <summary>
        /// VS Package that provides this command, not null.
        /// </summary>
        private readonly IUnitTestGeneratorPackage _package;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateUnitTestsCommand"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file).
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        /// <param name="commandService">Command service to add command to, not null.</param>
        private GenerateUnitTestsCommand(IUnitTestGeneratorPackage package, OleMenuCommandService commandService)
        {
            _package = package ?? throw new ArgumentNullException(nameof(package));
            commandService = commandService ?? throw new ArgumentNullException(nameof(commandService));

            var menuCommandId = new CommandID(CommandSet, CommandId);
            var regenerateMenuCommandId = new CommandID(CommandSet, RegenerateCommandId);

            var menuItem = new OleMenuCommand(Execute, menuCommandId);
            var regenerateMenuItem = new OleMenuCommand(ExecuteRegenerate, regenerateMenuCommandId);
            menuItem.BeforeQueryStatus += (s, e) =>
            {
                ThreadHelper.ThrowIfNotOnUIThread();
                var itemVisible = IsAvailable;
                menuItem.Visible = itemVisible;
                regenerateMenuItem.Visible = Keyboard.IsKeyDown(Key.LeftShift) && itemVisible;
            };

            commandService.AddCommand(menuItem);
            commandService.AddCommand(regenerateMenuItem);
        }

        private bool IsAvailable
        {
            get
            {
                ThreadHelper.ThrowIfNotOnUIThread();
                return SolutionUtilities.GetSelectedFiles(_dte, true, _package.Options.GenerationOptions).Any(ProjectItemModel.IsSupported);
            }
        }

        /// <summary>
        /// Initializes the singleton instance of the command.
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public static async Task InitializeAsync(IUnitTestGeneratorPackage package)
        {
            _dte = (DTE2)await package.GetServiceAsync(typeof(DTE)).ConfigureAwait(true);

            var commandService = await package.GetServiceAsync(typeof(IMenuCommandService)).ConfigureAwait(true) as OleMenuCommandService;
            _instance = new GenerateUnitTestsCommand(package, commandService);
        }

#pragma warning disable VSTHRD010

        private void Execute(object sender, EventArgs e)
        {
            Execute(false);
        }

        private void ExecuteRegenerate(object sender, EventArgs e)
        {
            Execute(true);
        }

#pragma warning restore VSTHRD010

        private void Execute(bool withRegeneration)
        {
            var generationItems = new List<GenerationItem>();
            var projectDictionary = new Dictionary<Project, HashSet<TargetAsset>>();

            var messageLogger = new AggregateLogger();
            messageLogger.Initialize();

            Attempt.Action(
                () =>
            {
                ThreadHelper.ThrowIfNotOnUIThread();
#pragma warning disable VSTHRD010

                if (!IsAvailable)
                {
                    throw new InvalidOperationException("Cannot generate unit tests for this item because no supported files were found");
                }

                var options = _package.Options;
                var sources = SolutionUtilities.GetSelectedFiles(_dte, true, options.GenerationOptions).Where(ProjectItemModel.IsSupported).ToList();

                var targetProjects = new Dictionary<Project, Tuple<Project, IGenerationOptions>>();

                foreach (var source in sources)
                {
                    if (targetProjects.ContainsKey(source.Project))
                    {
                        continue;
                    }

                    var targetProject = source.TargetProject;

                    if (targetProject == null && !options.GenerationOptions.AllowGenerationWithoutTargetProject)
                    {
                        throw new InvalidOperationException("Cannot create tests for '" + Path.GetFileName(source.FilePath) + "' because there is no project '" + source.TargetProjectName + "'");
                    }

                    if (targetProject != null)
                    {
                        var generationOptions = OptionsResolver.DetectFrameworks(targetProject, options.GenerationOptions);

                        targetProjects[source.Project] = Tuple.Create(targetProject, generationOptions);
                        projectDictionary[targetProject] = new HashSet<TargetAsset>();
                    }
                }

                foreach (var source in sources)
                {
                    var projectItem = source.Item;

                    if (!withRegeneration && TargetFinder.FindExistingTargetItem(source, options.GenerationOptions, out _) == FindTargetStatus.Found)
                    {
                        if (sources.Count == 1)
                        {
                            throw new InvalidOperationException("Cannot create tests for '" + Path.GetFileName(source.FilePath) + "' because tests already exist. If you want to re-generate tests for this item, hold down the left Shift key and right-click the item.");
                        }

                        continue;
                    }

                    var nameParts = VsProjectHelper.GetNameParts(projectItem);

                    targetProjects.TryGetValue(source.Project, out var targetProjectPair);
                    var targetProject = targetProjectPair?.Item1;
                    var targetProjectItems = TargetFinder.FindTargetFolder(targetProject, nameParts, true, out var targetPath);

                    if (targetProjectItems == null && !options.GenerationOptions.AllowGenerationWithoutTargetProject)
                    {
                        // we asked to create targetProjectItems - so if it's null we effectively had a problem getting to the target project
                        throw new InvalidOperationException("Cannot create tests for '" + Path.GetFileName(source.FilePath) + "' because there is no project '" + source.TargetProjectName + "'");
                    }

                    var sourceNameSpaceRoot = VsProjectHelper.GetProjectRootNamespace(source.Project);
                    HashSet<TargetAsset> requiredAssets;

                    if (targetProject != null && projectDictionary.TryGetValue(targetProject, out var targetProjectEntry))
                    {
                        requiredAssets = targetProjectEntry;
                    }
                    else
                    {
                        requiredAssets = new HashSet<TargetAsset>();
                    }

                    Func<string, string> namespaceTransform;
                    if (source.TargetProject != null)
                    {
                        var targetNameSpaceRoot = VsProjectHelper.GetProjectRootNamespace(source.TargetProject);
                        namespaceTransform = NamespaceTransform.Create(sourceNameSpaceRoot, targetNameSpaceRoot);
                    }
                    else
                    {
                        namespaceTransform = x => x + ".Tests";
                    }

                    generationItems.Add(new GenerationItem(source, null, targetProjectItems, targetPath, requiredAssets, namespaceTransform, targetProjectPair?.Item2 ?? options.GenerationOptions));
                }
#pragma warning restore VSTHRD010
            }, _package);

            if (generationItems.Any())
            {
                _ = _package.JoinableTaskFactory.RunAsync(() => Attempt.ActionAsync(() => CodeGenerator.GenerateCodeAsync(generationItems, withRegeneration, _package, projectDictionary, messageLogger), _package));
            }
        }
    }
}