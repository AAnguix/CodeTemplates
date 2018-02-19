namespace Cachopo.CodeTemplates
{
    using System;

    public class FileType : IFileType
    {
        public FileType(string extension, ICodeFormatter formatter)
        {
            Extension = FileExtensionValidator.IsValid(extension) 
                ? extension 
                : throw new ArgumentException("Provide a valid file extension.", nameof(extension));

            Formatter = formatter ?? throw new ArgumentNullException(nameof(formatter));
        }

        public string Extension { get; private set; }

        public ICodeFormatter Formatter { get; private set; }
    }
}
