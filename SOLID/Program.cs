using SOLID.OCP.Solution_Extension_Methods;
using CalculateArea = SOLID.LSP.Solution.CalculateArea;
using System;

namespace SOLID
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Choose the operation");
            Console.WriteLine("1 - OCP");
            Console.WriteLine("2 - LSP");

            ConsoleKeyInfo option = Console.ReadKey();

            switch (option.KeyChar)
            {
                case '1':
                    ATM.Operations();
                    break;
                case '2':
                    CalculateArea.Calculate();
                    break;
            }
        }
    }
}
