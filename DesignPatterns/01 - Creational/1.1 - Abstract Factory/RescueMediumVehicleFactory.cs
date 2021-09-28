namespace DesignPatterns.AbstractFactory
{
    // Concrete Factory
    public class MediumVehicleFactory : RescueServiceFactory
    {
        public override TowTruck CreateTowTruck()
        {
            return TowTruckCreator.Create(Size.Medium);
        }

        public override Vehicle CreateVehicle(string model, Size size)
        {
            return VehicleCreator.Create(model, size);
        }
    }
}