namespace Cachopo.CodeTemplates
{
    internal class NullFormatter : ICodeFormatter
    {
        public string Format(string code)
        {
            return code;
        }
    }
}