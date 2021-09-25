using System;

namespace SOLID.OCP.Solution_Extension_Methods
{
    public class ATM
    {
        public static void Operations()
        {
            OperationsMenu();

            ConsoleKeyInfo option = Console.ReadKey();
            string ret = string.Empty;

            DebitAccount debitAccount = DebitData();

            switch (option.KeyChar)
            {
                case '1':
                    Console.WriteLine("Performing Checking Account Operation");
                    ret = debitAccount.PerformDebitCheckingAccount();
                    break;
                case '2':
                    Console.WriteLine("Performing Savings Account Operation");
                    ret = debitAccount.PerformDebitSavingsAccount();
                    break;
                case '3':
                    Console.WriteLine("Performing Investment Account Operation");
                    ret = debitAccount.PerformDebitInvestmentAccount();
                    break;
            }

            ReturnTransaction(ret);
        }

        private static void OperationsMenu()
        {
            Console.Clear();
            Console.WriteLine("SOLID ATM");
            Console.WriteLine("Choose your option:");
            Console.WriteLine();
            Console.WriteLine("1 - Checking Account Withdrawal");
            Console.WriteLine("2 - Savings Account Withdrawal");
            Console.WriteLine("3 - Investment Account Withdrawal");
        }

        private static DebitAccount DebitData()
        {
            Console.WriteLine();
            Console.WriteLine("..............................");
            Console.WriteLine();
            Console.WriteLine("Enter the Account");
            string account = Console.ReadLine();
            Console.WriteLine("Enter the Value");
            decimal value = Convert.ToDecimal(Console.ReadLine());

            DebitAccount debitAccount = new DebitAccount()
            {
                AccountNumber = account,
                Value = value
            };

            return debitAccount;
        }

        private static void ReturnTransaction(string ret)
        {
            Console.WriteLine();
            Console.WriteLine("Sucess! Transaction: " + ret);
            Console.ReadKey();
        }
    }
}