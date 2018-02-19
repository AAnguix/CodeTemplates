namespace Cachopo.CodeTemplates.Examples.Builder
{
    /// <summary>
    /// The 'ConcreteBuilder2' class
    /// </summary>
    class BusBuilder : VehicleBuilder
    {
        public BusBuilder()
        {
            vehicle = new Vehicle("Bus");
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "5000 cc";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "8";
        }

        public override void BuildDoors()
        {
            vehicle["doors"] = "2";
        }
    }
}
