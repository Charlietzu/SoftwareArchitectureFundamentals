namespace OOP
{
    // Poly-morphism
    public class CoffeeMachine : HomeAppliance
    {
        public CoffeeMachine(string name, int voltage)
            : base(name, voltage) { }

        public CoffeeMachine()
            : base("Default", 220) { }

        private static void HeatWater() { }

        private static void GrindGrain() { }

        public void PrepareCoffee()
        {
            Test();
            HeatWater();
            GrindGrain();
        }

        public override void Test()
        {
            // Coffee Machine Test
        }

        public override void TurnOn()
        {
            // Check water container
        }

        public override void TurnOff()
        {
            // Cool heater
        }
    }
}