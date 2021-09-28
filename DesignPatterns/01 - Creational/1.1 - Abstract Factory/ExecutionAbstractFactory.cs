using System.Collections.Generic;

namespace DesignPatterns.AbstractFactory
{
    public class ExecutionAbstractFactory
    {
        public static void Execute()
        {
            List<Vehicle> vehiclesRescue = new List<Vehicle>
            {
                VehicleCreator.Create("Celta", Size.Small),
                VehicleCreator.Create("Jetta", Size.Medium),
                VehicleCreator.Create("BMW X6", Size.Big)
            };

            vehiclesRescue.ForEach(v => RescueService.CreateRescueService(v).PerformService());
        }
    }
}