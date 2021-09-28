using System;

namespace DesignPatterns.AbstractFactory
{
    // Abstract Product   
    public abstract class TowTruck
    {
        protected TowTruck(Size size)
        {
            Size = size;
        }

        public abstract void Rescue(Vehicle vehicle);
        public Size Size { get; set; }
    }

    // Concrete Product
    public class SmallTowTruck : TowTruck
    {
        public SmallTowTruck(Size size) : base(size) { }

        public override void Rescue(Vehicle vehicle)
        {
            // Rescue process
            Console.WriteLine("Helping small car - Model " + vehicle.Model);
        }
    }

    // Concrete Product
    public class MediumTowTruck : TowTruck
    {
        public MediumTowTruck(Size size) : base(size) { }

        public override void Rescue(Vehicle vehicle)
        {
            // Rescue process
            Console.WriteLine("Helping medium car - Model " + vehicle.Model);
        }
    }

    // Concrete Product
    public class BigTowTruck : TowTruck
    {
        public BigTowTruck(Size size) : base(size) { }

        public override void Rescue(Vehicle vehicle)
        {
            // Rescue process
            Console.WriteLine("Helping big car - Model " + vehicle.Model);
        }
    }

    public class TowTruckCreator
    {
        public static TowTruck Create(Size size)
        {
            switch (size)
            {
                case Size.Small:
                    return new SmallTowTruck(size);
                case Size.Medium:
                    return new MediumTowTruck(size);
                case Size.Big:
                    return new BigTowTruck(size);
                default:
                    throw new ApplicationException("Unknown Tow Truck size.");
            }
        }
    }
}