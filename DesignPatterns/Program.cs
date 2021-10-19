using System;
using DesignPatterns.FactoryMethod;
using ExecutionAbstractFactory = DesignPatterns.AbstractFactory.ExecutionAbstractFactory;

namespace DesignPatterns
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Choose the operation:");
            Console.WriteLine("------------------------");
            Console.WriteLine("Creational Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - Abstract Factory");
            Console.WriteLine("2 - Method Factory");
            Console.WriteLine("3 - Singleton");
            Console.WriteLine("------------------------");
            Console.WriteLine("Structural Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("4 - Adapter");
            Console.WriteLine("5 - Facade");
            Console.WriteLine("6 - Composite");
            Console.WriteLine("------------------------");
            Console.WriteLine("Behavioral Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("7 - Command");
            Console.WriteLine("8 - Strategy");
            Console.WriteLine("9 - Observer");
            Console.WriteLine("------------------------");

            ConsoleKeyInfo option = Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("");

            switch (option.KeyChar)
            {
                case '1':
                    ExecutionAbstractFactory.Execute();
                    break;
                case '2':
                    ExecutionFactoryMethod.Execute();
                    break;
                case '3':
                    ExecutionSingleton.Execute();
                    break;
                case '4':
                    ExecutionAdapter.Execute();
                    break;
                case '5':
                    ExecutionFacade.Execute();
                    break;
                case '6':
                    ExecutionComposite.Execute();
                    break;
                case '7':
                    ExecutionCommand.Execute();
                    break;
                case '8':
                    ExecutionStrategy.Execute();
                    break;
                case '9':
                    ExecutionObservable.Execute();
                    break;
            }

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
