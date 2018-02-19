namespace Cachopo.CodeTemplates.Examples.Builder
{
    /// <summary>
    /// The 'ConcreteBuilder3' class
    /// </summary>
    class TrainBuilder : VehicleBuilder
    {
        public TrainBuilder()
        {
            vehicle = new Vehicle("Train");
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "20000 cc";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "0";
        }

        public override void BuildDoors()
        {
            vehicle["doors"] = "50";
        }
    }
}
