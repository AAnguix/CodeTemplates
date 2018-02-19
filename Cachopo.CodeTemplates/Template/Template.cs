using System.Runtime.CompilerServices;

namespace Cachopo.CodeTemplates
{
    using System;
    using System.Collections.Generic;

    public class Template : ITemplate
    {
        public IList<IFile> Files { get; private set; }

        public string DestinationFolder { get; private set; }

        /// <summary>
        /// A template is composed of a group of code files.
        /// </summary>
        /// <param name="destinationFolder">The folder where all the files will be created.</param>
        public Template(string destinationFolder)
        {
            DestinationFolder = !string.IsNullOrWhiteSpace(destinationFolder)
                ? destinationFolder 
                : throw new ArgumentException("Provide a valid destination folder.", nameof(destinationFolder));

            Files = new List<IFile>();
        }

        public void AddFile(string code, string fileName, IFileType type)
        {
            var file = new File(code, fileName, DestinationFolder, type);
            Files.Add(file);
        }
    }
}