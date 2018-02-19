namespace Cachopo.CodeTemplates
{
    public static class CodeFormatters
    {
        /// <summary>
        /// Formats the code with the default C# rules.
        /// </summary>
        public static ICodeFormatter CSharp { get; private set; }

        /// <summary>
        /// Leaves the code exactly the same as the original.
        /// </summary>
        public static ICodeFormatter Null { get; private set; }

        static CodeFormatters()
        {
            CSharp = new CsharpDefaultFormatter();

            Null = new NullFormatter();
        }
    }
}
