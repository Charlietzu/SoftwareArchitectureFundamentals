using System;

namespace DesignPatterns
{
    internal class Calculator
    {
        private int _actualValue;

        public void Operation(char op, int value)
        {
            switch (op)
            {
                case '+': _actualValue += value; break;
                case '-': _actualValue -= value; break;
                case '*': _actualValue *= value; break;
                case '/': _actualValue /= value; break;
            }
            Console.WriteLine("(given {1} {2}) - Actual value = {0,3}", _actualValue, op, value);
        }
    }
}