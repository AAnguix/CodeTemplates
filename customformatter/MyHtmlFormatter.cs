using Cachopo.CodeTemplates;

class MyHtmlFormatter : ICodeFormatter
{
    /// <summary>
    /// Here you can apply the formatting rules that are appropriate, call external tools, etc.
    /// </summary>
    public string Format(string code)
    {
        return code;
    }
}