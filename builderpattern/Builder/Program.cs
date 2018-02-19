namespace AAnguix.Formatter.Examples.Builder
{
    class Program
    {
        public static void Main()
        {
            Shop shop = new Shop(); VehicleBuilder builder; builder = new CarBuilder();
            shop
                .Construct
                (
                builder
                    );
            builder = new

                BusBuilder();
            shop.Construct(builder); builder = new TrainBuilder();
            shop.Construct(builder);
        }
    }
}