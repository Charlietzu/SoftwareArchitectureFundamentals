using System;

namespace SOLID.LSP.Solution
{
    public class CalculateArea
    {
        private static void GetParallelogramArea(Parallelogram parallelogram)
        {
            Console.Clear();
            Console.WriteLine("Calculate Parallelogram Area");
            Console.WriteLine();
            Console.WriteLine(parallelogram.Height + " * " + parallelogram.Width);
            Console.WriteLine();
            Console.WriteLine(parallelogram.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {
            Square quad = new Square(5, 5);
            Rectangle ret = new Rectangle(10, 5);

            GetParallelogramArea(quad);
            GetParallelogramArea(ret);
        }
    }
}