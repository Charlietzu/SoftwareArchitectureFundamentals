using System;

namespace DesignPatterns
{
    internal class CommandCalculator : Commander
    {
        private char _op;
        private int _value;
        private readonly Calculator _calculator;

        public CommandCalculator(Calculator calculator, char op, int value)
        {
            _calculator = calculator;
            _op = op;
            _value = value;
        }

        public char Operator
        {
            set => _op = value;
        }

        public int Operand
        {
            set => _value = value;
        }

        public override void Execute()
        {
            _calculator.Operation(_op, _value);
        }

        public override void Undo()
        {
            _calculator.Operation(Undo(_op), _value);
        }

        private static char Undo(char op)
        {
            switch (op)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("Unknown operator");
            }
        }
    }
}