namespace Cachopo.CodeTemplates
{
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using Microsoft.CodeAnalysis.MSBuild;
    using Microsoft.CodeAnalysis.Formatting;
    using Microsoft.CodeAnalysis.Options;

    public class CsharpDefaultFormatter : ICodeFormatter
    {
        private readonly Workspace _workspace;

        internal CsharpDefaultFormatter()
        {
            _workspace = MSBuildWorkspace.Create();
        }

        public string Format(string code)
        {
            var syntaxTree = CSharpSyntaxTree.ParseText(code);
            OptionSet options = _workspace.Options.SetCsharpCodingConventionsOptions();

            var syntaxNode = Formatter.Format(syntaxTree.GetRoot(), _workspace, options);
            return syntaxNode.ToFullString();
        }
    }
}