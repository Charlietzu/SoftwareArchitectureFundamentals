using System;

namespace DesignPatterns.AbstractFactory
{
    // Client Class
    public class RescueService
    {
        private readonly Vehicle _vehicle;
        private readonly TowTruck _towTruck;

        public RescueService(RescueServiceFactory factory, Vehicle vehicle)
        {
            _vehicle = factory.CreateVehicle(vehicle.Model, vehicle.Size);
            _towTruck = factory.CreateTowTruck();
        }

        public void PerformService()
        {
            _towTruck.Rescue(_vehicle);
        }

        public static RescueService CreateRescueService(Vehicle vehicle)
        {
            switch (vehicle.Size)
            {
                case Size.Small:
                    return new RescueService(new SmallVehicleFactory(), vehicle);
                case Size.Medium:
                    return new RescueService(new MediumVehicleFactory(), vehicle);
                case Size.Big:
                    return new RescueService(new BigVehicleFactory(), vehicle);
                default:
                    throw new ApplicationException("Unable to identify the vehicle");
            }
        }
    }
}