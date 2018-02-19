namespace Cachopo.CodeTemplates
{
    using System.Linq;

    public static class FileExtensionValidator
    {
        public static bool IsValid(string extension)
        {
            return !string.IsNullOrWhiteSpace(extension)
                && extension[0] == '.';
        }
    }
}
