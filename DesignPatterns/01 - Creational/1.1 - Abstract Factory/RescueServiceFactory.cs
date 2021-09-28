namespace DesignPatterns.AbstractFactory
{
    // Abstract Factory
    public abstract class RescueServiceFactory
    {
        public abstract TowTruck CreateTowTruck();
        public abstract Vehicle CreateVehicle(string model, Size size);
    }
}