using System;

namespace SOLID.LSP.Violation
{
    public class CalculateArea
    {
        private static void GetRectangleArea(Rectangle rec)
        {
            Console.Clear();
            Console.WriteLine("Calculate Rectangle Area");
            Console.WriteLine();
            Console.WriteLine(rec.Height + " * " + rec.Width);
            Console.WriteLine();
            Console.WriteLine(rec.Area);
            Console.ReadKey();
        }

        public static void Calculate()
        {
            Square square = new Square()
            {
                Height = 10,
                Width = 5
            };

            GetRectangleArea(square);
        }
    }
}