using System;

namespace DesignPatterns
{
    //Adaptee Class
    public class LogNetMasterService : ILogNetMaster
    {
        public void LogInfo(string message)
        {
            Console.WriteLine("Custom Log - " + message);
        }        
        
        public void LogException(Exception exception)
        {
            Console.WriteLine("Custom Log - " + exception.Message);
        }
    }
}
