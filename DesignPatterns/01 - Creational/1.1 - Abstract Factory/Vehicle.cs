using System;

namespace DesignPatterns.AbstractFactory
{
    // Abstract Product  
    public abstract class Vehicle
    {
        protected Vehicle(string model, Size size)
        {
            Model = model;
            Size = size;
        }

        public string Model { get; set; }
        public Size Size { get; set; }

    }

    public enum Size
    {
        Small,
        Medium,
        Big
    }

    // Concrete Product
    public class SmallVehicle : Vehicle
    {
        public SmallVehicle(string model, Size size) : base(model, size)
        {
        }
    }

    // Concrete Product
    public class MediumVehicle : Vehicle
    {
        public MediumVehicle(string model, Size size) : base(model, size)
        {
        }
    }

    // Concrete Product
    public class BigVehicle : Vehicle
    {
        public BigVehicle(string model, Size size) : base(model, size)
        {
        }
    }

    public class VehicleCreator
    {
        public static Vehicle Create(string model, Size size)
        {
            switch (size)
            {
                case Size.Small:
                    return new SmallVehicle(model, size);
                case Size.Medium:
                    return new MediumVehicle(model, size);
                case Size.Big:
                    return new BigVehicle(model, size);
                default:
                    throw new ApplicationException("Unknown vehicle size.");
            }
        }
    }
}