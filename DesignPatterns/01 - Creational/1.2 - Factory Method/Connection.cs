using System;

namespace DesignPatterns.FactoryMethod
{
    public class Connection
    {
        public string ConnectionString { get; set; }
        public bool Opened { get; set; }

        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void ExecuteCommand(string command)
        {
            Console.WriteLine("Executing Command: " + command);
        }

        public void Open()
        {
            Opened = true;
            Console.WriteLine("Connection open");
        }

        public void Close()
        {
            Console.WriteLine("Connection closed");
        }
    }
}