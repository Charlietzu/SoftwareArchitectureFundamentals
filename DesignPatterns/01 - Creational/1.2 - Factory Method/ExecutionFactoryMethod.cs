using System;

namespace DesignPatterns.FactoryMethod
{
    public class ExecutionFactoryMethod
    {
        public static void Execute()
        {
            Connection sqlCn = DbFactory.Database(DataBase.SqlServer)
                                 .CreateConnector("myConnectionString")
                                 .Connect();

            sqlCn.ExecuteCommand("select * from tableSqlServer");
            sqlCn.Close();

            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");

            Connection oracleCn = DbFactory.Database(DataBase.Oracle)
                                    .CreateConnector("myConnectionString")
                                    .Connect();

            oracleCn.ExecuteCommand("select * from tableOracle");
            oracleCn.Close();
        }
    }
}