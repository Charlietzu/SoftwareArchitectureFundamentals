using System;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose operation:");
            Console.WriteLine("");
            Console.WriteLine("1 - Encapsulation");
            Console.WriteLine("2 - Inheritance Composition 1");
            Console.WriteLine("3 - Inheritance Composition 2");
            Console.WriteLine("4 - Interface Implementation");

            ConsoleKeyInfo option = Console.ReadKey();

            switch (option.KeyChar)
            {
                case '1':
                    new CoffeeAutomation().ServeCoffee();
                    break;
                case '2':
                    new InheritanceCompositionTest();
                    break;
                case '3':
                    new InheritanceCompositionTest2();
                    break;
                case '4':
                    new InterfaceImplementationTest();
                    break;
            }

            Main();
        }
    }
}
