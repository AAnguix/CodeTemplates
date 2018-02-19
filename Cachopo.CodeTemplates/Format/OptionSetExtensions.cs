namespace Microsoft.CodeAnalysis.Options
{
    using Microsoft.CodeAnalysis.CSharp.Formatting;

    internal static class OptionSetExtensions
    {
        internal static OptionSet SetCsharpCodingConventionsOptions(this OptionSet options)
        {
            return options
                .WithChangedOption(CSharpFormattingOptions.IndentBlock, true)
                .WithChangedOption(CSharpFormattingOptions.IndentBraces, false)
                .WithChangedOption(CSharpFormattingOptions.IndentSwitchCaseSection, true)
                .WithChangedOption(CSharpFormattingOptions.IndentSwitchCaseSectionWhenBlock, true)
                .WithChangedOption(CSharpFormattingOptions.IndentSwitchSection, true)
                .WithChangedOption(CSharpFormattingOptions.LabelPositioning, LabelPositionOptions.NoIndent)
                .WithChangedOption(CSharpFormattingOptions.NewLineForCatch, true)
                .WithChangedOption(CSharpFormattingOptions.NewLineForClausesInQuery, true)
                .WithChangedOption(CSharpFormattingOptions.NewLineForElse, true)
                .WithChangedOption(CSharpFormattingOptions.NewLineForFinally, true)

                .WithChangedOption(CSharpFormattingOptions.NewLineForMembersInAnonymousTypes, true)
                .WithChangedOption(CSharpFormattingOptions.NewLineForMembersInObjectInit, true)
                .WithChangedOption(CSharpFormattingOptions.NewLinesForBracesInAccessors, true)
                .WithChangedOption(CSharpFormattingOptions.NewLinesForBracesInAnonymousMethods, true)
                .WithChangedOption(CSharpFormattingOptions.NewLinesForBracesInAnonymousTypes, true)
                .WithChangedOption(CSharpFormattingOptions.NewLinesForBracesInControlBlocks, true)
                .WithChangedOption(CSharpFormattingOptions.NewLinesForBracesInLambdaExpressionBody, true)
                .WithChangedOption(CSharpFormattingOptions.NewLinesForBracesInMethods, true)
                .WithChangedOption(CSharpFormattingOptions.NewLinesForBracesInObjectCollectionArrayInitializers, true)
                .WithChangedOption(CSharpFormattingOptions.NewLinesForBracesInProperties, true)

                .WithChangedOption(CSharpFormattingOptions.NewLinesForBracesInTypes, true)
                .WithChangedOption(CSharpFormattingOptions.SpaceAfterCast, true)
                .WithChangedOption(CSharpFormattingOptions.SpaceAfterColonInBaseTypeDeclaration, true)
                .WithChangedOption(CSharpFormattingOptions.SpaceAfterComma, true)
                .WithChangedOption(CSharpFormattingOptions.SpaceAfterControlFlowStatementKeyword, true)
                .WithChangedOption(CSharpFormattingOptions.SpaceAfterDot, true)
                .WithChangedOption(CSharpFormattingOptions.SpaceAfterMethodCallName, false)
                .WithChangedOption(CSharpFormattingOptions.SpaceAfterSemicolonsInForStatement, true)
                .WithChangedOption(CSharpFormattingOptions.SpaceBeforeColonInBaseTypeDeclaration, false)
                .WithChangedOption(CSharpFormattingOptions.SpaceBeforeComma, false)

                .WithChangedOption(CSharpFormattingOptions.SpaceBeforeDot, false)
                .WithChangedOption(CSharpFormattingOptions.SpaceBeforeOpenSquareBracket, true)
                .WithChangedOption(CSharpFormattingOptions.SpaceBeforeSemicolonsInForStatement, true)
                .WithChangedOption(CSharpFormattingOptions.SpaceBetweenEmptyMethodCallParentheses, false)
                .WithChangedOption(CSharpFormattingOptions.SpaceBetweenEmptyMethodDeclarationParentheses, true)
                .WithChangedOption(CSharpFormattingOptions.SpaceBetweenEmptySquareBrackets, true)
                .WithChangedOption(CSharpFormattingOptions.SpacesIgnoreAroundVariableDeclaration, true)
                .WithChangedOption(CSharpFormattingOptions.SpaceWithinCastParentheses, true)
                .WithChangedOption(CSharpFormattingOptions.SpaceWithinExpressionParentheses, true)
                .WithChangedOption(CSharpFormattingOptions.SpaceWithinMethodCallParentheses, true)

                .WithChangedOption(CSharpFormattingOptions.SpaceWithinMethodDeclarationParenthesis, true)
                .WithChangedOption(CSharpFormattingOptions.SpaceWithinOtherParentheses, true)
                .WithChangedOption(CSharpFormattingOptions.SpaceWithinSquareBrackets, true)
                .WithChangedOption(CSharpFormattingOptions.SpacingAfterMethodDeclarationName, true)
                .WithChangedOption(CSharpFormattingOptions.SpacingAroundBinaryOperator, BinaryOperatorSpacingOptions.Remove)
                .WithChangedOption(CSharpFormattingOptions.WrappingKeepStatementsOnSingleLine, false)
                .WithChangedOption(CSharpFormattingOptions.WrappingPreserveSingleLine, false);
        }
    }
}