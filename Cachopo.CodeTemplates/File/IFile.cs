namespace Cachopo.CodeTemplates
{
    public interface IFile
    {
        string Code { get; }

        string Name { get; }

        string Path { get; }

        IFileType Type { get; }
    }
}