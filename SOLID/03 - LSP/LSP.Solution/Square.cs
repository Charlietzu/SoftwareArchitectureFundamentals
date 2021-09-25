using System;

namespace SOLID.LSP.Solution
{
    public class Square : Parallelogram
    {
        public Square(int height, int width)
          : base(height, width)
        {
            if (width != height)
                throw new ArgumentException("Both sides of the square must be equal");
        }
    }
}