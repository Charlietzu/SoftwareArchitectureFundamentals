using System;

namespace DesignPatterns
{
    public class ExecutionCommand
    {
        public static void Execute()
        {
            User user = new User();

            user.Add('+', 100);
            Console.ReadKey();
            user.Add('-', 50);
            Console.ReadKey();
            user.Add('*', 10);
            Console.ReadKey();
            user.Add('/', 2);
            Console.ReadKey();

            user.Undo(4);
            Console.ReadKey();

            user.Return(3);
        }
    }
}