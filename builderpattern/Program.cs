using Cachopo.CodeTemplates;

class Program
{
    static void Main(string[] args)
    {
        var component = new BuilderPatternComponent("Folder");
        new TemplateBuilder().Build(component);
    }
}
