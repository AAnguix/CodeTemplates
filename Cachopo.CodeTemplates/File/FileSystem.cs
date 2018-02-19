namespace Cachopo.CodeTemplates
{
    using System.IO;

    internal class FileSystem : IFileSystem
    {
        public bool ExistsDirectory(string path)
        {
            return Directory.Exists(path);
        }

        public DirectoryInfo CreateDirectory(string path)
        {
            return Directory.CreateDirectory(path);
        }

        public void CreateFile(string path, string content)
        {
            System.IO.File.WriteAllText(path, content);
        }

        public string Combine(params string[] paths)
        {
            return Path.Combine(paths);
        }
    }
}