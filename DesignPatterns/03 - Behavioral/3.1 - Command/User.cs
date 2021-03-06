using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class User
    {
        private readonly Calculator _calculator = new Calculator();
        private readonly List<Commander> _commands = new List<Commander>();
        private int _total;

        public void Add(char op, int value)
        {
            Commander command = new CommandCalculator(_calculator, op, value);
            command.Execute();

            _commands.Add(command);
            _total++;
        }

        public void Return(int levels)
        {
            Console.WriteLine("\n---- Returning {0} levels ", levels);

            for (int i = 0; i < levels; i++)
            {
                if (_total >= _commands.Count - 1) continue;
                Commander command = _commands[_total++];
                command.Execute();
            }
        }

        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undoing {0} levels ", levels);

            for (int i = 0; i < levels; i++)
            {
                if (_total <= 0) continue;
                Commander command = _commands[--_total];
                command.Undo();
            }
        }
    }
}