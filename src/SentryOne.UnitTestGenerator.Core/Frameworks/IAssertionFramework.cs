﻿namespace SentryOne.UnitTestGenerator.Core.Frameworks
{
    using System.Collections.Generic;
    using Microsoft.CodeAnalysis.CSharp.Syntax;

    public interface IAssertionFramework
    {
        bool AssertThrowsAsyncIsAwaitable { get; }

        IEnumerable<UsingDirectiveSyntax> GetUsings();

        StatementSyntax AssertEqual(ExpressionSyntax actual, ExpressionSyntax expected, bool isReferenceType);

        StatementSyntax AssertFail(string message);

        StatementSyntax AssertGreaterThan(ExpressionSyntax actual, ExpressionSyntax expected);

        StatementSyntax AssertIsInstanceOf(ExpressionSyntax value, TypeSyntax type, bool isReferenceType);

        StatementSyntax AssertLessThan(ExpressionSyntax actual, ExpressionSyntax expected);

        StatementSyntax AssertNotNull(ExpressionSyntax value);

        StatementSyntax AssertThrows(TypeSyntax exceptionType, ExpressionSyntax methodCall);

        StatementSyntax AssertThrowsAsync(TypeSyntax exceptionType, ExpressionSyntax methodCall);
    }
}