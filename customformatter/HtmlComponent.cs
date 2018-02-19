using Cachopo.CodeTemplates;
/// <summary>
/// Example of custom code formatting.
/// </summary>
public class HtmlComponent : Template
{
    public HtmlComponent(string destinationFolder)
    : base(destinationFolder)
    {
        // We declare a '.html' file type with the corresponding formatter.
        var html = new FileType(".html", new MyHtmlFormatter());

        //We add a new file to this component
        AddFile(HtmlCode(), "index", html);
    }

    private string HtmlCode()
    {
        return "<!DOCTYPE html> "
        + "< html > < body > < p > This is a paragraph.</ p >"
        + "< p > This is another paragraph.</ p >"
        + "</ body >"
        + "</ html > ";
    }
}
