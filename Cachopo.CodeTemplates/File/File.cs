namespace Cachopo.CodeTemplates
{
    using System;

    internal class File : IFile
    {
        internal File(string code, string name, string path, IFileType type)
        {
            Name = name ?? throw new ArgumentNullException(nameof(code));
            Path = path ?? throw new ArgumentNullException(nameof(path));
            Type = type ?? throw new ArgumentNullException(nameof(type));
            Code = type.Formatter.Format(code);
        }

        public string Code {get; private set;}

        public string Name { get; private set; }

        public string Path { get; private set; }

        public IFileType Type { get; private set; }
    }
}
