namespace Cachopo.CodeTemplates.Tests
{
    using Cachopo.CodeTemplates;

    class FileTypes
    {
        public static IFileType Cs
        {
            get { return new FileType(".cs", new CsharpDefaultFormatter()); }
        }
    }
}