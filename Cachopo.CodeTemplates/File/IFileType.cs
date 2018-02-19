namespace Cachopo.CodeTemplates
{
    public interface IFileType
    {
        string Extension { get; }

        ICodeFormatter Formatter { get; }
    }
}
