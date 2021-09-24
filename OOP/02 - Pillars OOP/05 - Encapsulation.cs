namespace OOP
{
    public class CoffeeAutomation
    {
        public void ServeCoffee()
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            coffeeMachine.TurnOn();
            coffeeMachine.PrepareCoffee();
            coffeeMachine.TurnOff();
        }
    }
}