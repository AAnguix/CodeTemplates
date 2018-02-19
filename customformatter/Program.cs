using Cachopo.CodeTemplates;

class Program
{
    static void Main(string[] args)
    {
        var htmlComponent = new HtmlComponent("MyFolder");
        new TemplateBuilder().Build(htmlComponent);
    }
}
