﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Unitverse.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Unitverse.Properties.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Project Sdk=&quot;Microsoft.NET.Sdk&quot;&gt;
        ///
        ///  &lt;PropertyGroup&gt;
        ///    &lt;TargetFramework&gt;$$TARGETFRAMEWORK$$&lt;/TargetFramework&gt;
        ///    &lt;IsPackable&gt;false&lt;/IsPackable&gt;
        ///  &lt;/PropertyGroup&gt;
        ///
        ///  &lt;ItemGroup&gt;
        ///    &lt;PackageReference Include=&quot;Microsoft.NET.Test.Sdk&quot; Version=&quot;16.11.0&quot; /&gt;
        ///    &lt;PackageReference Include=&quot;xunit&quot; Version=&quot;2.4.1&quot; /&gt;
        ///    &lt;PackageReference Include=&quot;xunit.runner.visualstudio&quot; Version=&quot;2.4.3&quot;&gt;
        ///      &lt;IncludeAssets&gt;runtime; build; native; contentfiles; analyzers; buildtransitive&lt;/IncludeAssets&gt;
        ///      &lt;Pr [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DefaultProjectContent {
            get {
                return ResourceManager.GetString("DefaultProjectContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //   _   _      _ _                       
        /////  | | | |_ _ (_) |___ _____ _ _ ___ ___ 
        /////  | |_| | &apos; \| |  _\ V / -_) &apos;_(_-&lt;/ -_)
        /////   \___/|_||_|_|\__|\_/\___|_| /__/\___|
        ///                                     
        ///// This file was generated with Unitverse
        ///// It has not been added to a test project because an existing test project was not found with the name &apos;$$TARGETNAME$$&apos;.
        ///
        ///// If this isn&apos;t the name you were expecting, you can change the naming pattern by going to Tools -&gt; Options -&gt; Unitverse.
        ///// Ot [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DisconnectedFileHeader {
            get {
                return ResourceManager.GetString("DisconnectedFileHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //   _   _      _ _                       
        /////  | | | |_ _ (_) |___ _____ _ _ ___ ___ 
        /////  | |_| | &apos; \| |  _\ V / -_) &apos;_(_-&lt;/ -_)
        /////   \___/|_||_|_|\__|\_/\___|_| /__/\___|
        ///                                     
        ///// This file was generated with Unitverse
        ///// It has not been added to a test project because generation of a detached file was selected in the user interface.
        ///.
        /// </summary>
        internal static string ElectiveDisconnectedFileHeader {
            get {
                return ResourceManager.GetString("ElectiveDisconnectedFileHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot not derive target project name, please check the test project naming setting..
        /// </summary>
        internal static string ProjectItemModel_ProjectItemModel_Cannot_not_derive_target_project_name__please_check_the_test_project_naming_setting_ {
            get {
                return ResourceManager.GetString("ProjectItemModel_ProjectItemModel_Cannot_not_derive_target_project_name__please_c" +
                        "heck_the_test_project_naming_setting_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The VSLangProj.VSProject instance could not be found..
        /// </summary>
        internal static string ReferencesHelper_AddReferencesToProject_The_VSLangProj_VSProject_instance_could_not_be_found_ {
            get {
                return ResourceManager.GetString("ReferencesHelper_AddReferencesToProject_The_VSLangProj_VSProject_instance_could_n" +
                        "ot_be_found_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find source project location.
        /// </summary>
        internal static string SolutionUtilities_CreateTestProjectInCurrentSolution_Cannot_find_source_project_location {
            get {
                return ResourceManager.GetString("SolutionUtilities_CreateTestProjectInCurrentSolution_Cannot_find_source_project_l" +
                        "ocation", resourceCulture);
            }
        }
    }
}
