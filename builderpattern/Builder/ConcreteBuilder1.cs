namespace Cachopo.CodeTemplates.Examples.Builder
{
    /// <summary>
    /// The 'ConcreteBuilder1' class
    /// </summary>
    class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            vehicle = new Vehicle("Car");
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "1000 cc";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "4";
        }

        public override void BuildDoors()
        {
            vehicle["doors"] = "4";
        }
    }
}