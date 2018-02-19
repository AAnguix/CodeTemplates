namespace Cachopo.CodeTemplates
{
    using System.IO;

    public interface IFileSystem
    {
        bool ExistsDirectory(string path);

        DirectoryInfo CreateDirectory(string path);

        void CreateFile(string path, string content);

        string Combine(params string[] paths);
    }
}