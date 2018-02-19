using Cachopo.CodeTemplates;
/// <summary>
/// Example of a component that will create the necesary classes to implement a Builder Pattern.
/// </summary>
public class BuilderPatternComponent : Template
{
    public BuilderPatternComponent(string destinationFolder) 
    : base(destinationFolder)
    {
        // The files will have .cs extension and will be formatted with the default CSharp rules.
        var cs = new FileType(".cs", CodeFormatters.CSharp);

        AddFile(ProgramCode(), "Program", cs);
        AddFile(DirectorCode(), "Shop", cs);
        AddFile(BuilderCode(), "VehicleBuilder", cs);
        AddFile(ProductCode(), "Vehicle", cs);
        AddFile(ConcreteBuilderCode(1), "CarBuilder", cs);
        AddFile(ConcreteBuilderCode(2), "BusBuilder", cs);
        AddFile(ConcreteBuilderCode(3), "TrainBuilder", cs);
    }

    /// <summary>
    /// The code is read from files.
    /// </summary>
    /// <returns></returns>
    private string DirectorCode()
    {
        return System.IO.File.ReadAllText("Builder/Director.cs");
    }

    private string BuilderCode()
    {
        return System.IO.File.ReadAllText("Builder/Builder.cs");
    }

    private string ProductCode()
    {
        return System.IO.File.ReadAllText("Builder/Product.cs");
    }

    private string ConcreteBuilderCode(int index)
    {
        return System.IO.File.ReadAllText($"Builder/ConcreteBuilder{index}.cs");
    }

    private string ProgramCode()
    {
        return System.IO.File.ReadAllText($"Builder/Program.cs");
    }
}
