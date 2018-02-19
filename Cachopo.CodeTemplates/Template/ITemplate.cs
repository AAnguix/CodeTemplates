namespace Cachopo.CodeTemplates
{
    using System.Collections.Generic;

    public interface ITemplate
    {
        /// <summary>
        /// Adds a code file.
        /// </summary>
        /// <param name="code">The code that will be written in the file.</param>
        /// <param name="fileName">The name of the file.</param>
        /// <param name="type">The type of file that will be generated.</param>
        void AddFile(string code, string fileName, IFileType type);

        IList<IFile> Files { get; }

        string DestinationFolder { get; }
    }
}