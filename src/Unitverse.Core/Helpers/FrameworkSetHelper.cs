﻿namespace Unitverse.Core.Helpers
{
    using System;
    using Microsoft.CodeAnalysis.CSharp;
    using Microsoft.CodeAnalysis.CSharp.Syntax;
    using Unitverse.Core.Frameworks;

    public static class FrameworkSetHelper
    {
        public static ExpressionSyntax QualifyFieldReference(this IFrameworkSet frameworkSet, SimpleNameSyntax nameSyntax)
        {
            if (frameworkSet is null)
            {
                throw new ArgumentNullException(nameof(frameworkSet));
            }

            if (nameSyntax is null)
            {
                throw new ArgumentNullException(nameof(nameSyntax));
            }

            var isStatic = frameworkSet.Context.CurrentModel?.IsStatic ?? false;
            var testClassIsStatic = isStatic && frameworkSet.TestFramework.SupportsStaticTestClasses;
            if (frameworkSet.Options.GenerationOptions.PrefixFieldReferencesWithThis && !testClassIsStatic)
            {
                return Generate.MemberAccess(SyntaxFactory.ThisExpression(), nameSyntax);
            }

            return nameSyntax;
        }

        public static ClassDeclarationSyntax ApplyTestClassAttribute(this IFrameworkSet frameworkSet, ClassDeclarationSyntax classDeclarationSyntax)
        {
            if (!frameworkSet.Options.GenerationOptions.OmitTestClassAttribute &&
                !string.IsNullOrWhiteSpace(frameworkSet.TestFramework.TestClassAttribute))
            {
                var testFixtureAtt = Generate.Attribute(frameworkSet.TestFramework.TestClassAttribute);
                return classDeclarationSyntax.AddAttributeLists(testFixtureAtt.AsList());
            }

            return classDeclarationSyntax;
        }
    }
}
