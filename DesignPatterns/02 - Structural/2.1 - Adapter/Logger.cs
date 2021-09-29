using System;

namespace DesignPatterns
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Default log - " + message);
        }        
        
        public void LogError(Exception exception)
        {
            Console.WriteLine("Default log - " + exception.Message);
        }

    }
}
