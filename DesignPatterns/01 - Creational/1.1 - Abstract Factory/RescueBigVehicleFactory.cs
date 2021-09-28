namespace DesignPatterns.AbstractFactory
{
    // Concrete Factory
    public class BigVehicleFactory : RescueServiceFactory
    {
        public override TowTruck CreateTowTruck()
        {
            return TowTruckCreator.Create(Size.Big);
        }

        public override Vehicle CreateVehicle(string model, Size size)
        {
            return VehicleCreator.Create(model, size);
        }
    }
}