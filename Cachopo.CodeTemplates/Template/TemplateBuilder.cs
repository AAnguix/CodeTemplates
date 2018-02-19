namespace Cachopo.CodeTemplates
{
    using System;

    public class TemplateBuilder : ITemplateBuilder
    {
        private readonly IFileSystem _fileSystem;

        public TemplateBuilder()
        {
            _fileSystem = new FileSystem();
        }

        internal TemplateBuilder(IFileSystem fileSystem)
        {
            _fileSystem = fileSystem ?? throw new ArgumentNullException(nameof(fileSystem));
        }

        public void Build(ITemplate codeTemplate)
        {
            if(codeTemplate == null)
            {
                throw new ArgumentNullException(nameof(codeTemplate));
            }

            if (!_fileSystem.ExistsDirectory(codeTemplate.DestinationFolder))
            {
                _fileSystem.CreateDirectory(codeTemplate.DestinationFolder);
            }

            foreach(var file in codeTemplate.Files)
            {
                string fullPath = GetFileFullPath(file.Path, file.Name, file.Type.Extension);
                _fileSystem.CreateFile(fullPath, file.Code);
            }
        }

        private string GetFileFullPath(string path, string fileName, string extension)
        {
            return $"{_fileSystem.Combine(path, fileName)}{extension}";
        }
    }
}