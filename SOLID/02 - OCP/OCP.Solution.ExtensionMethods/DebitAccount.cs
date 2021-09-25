using System;
using System.Linq;

namespace SOLID.OCP.Solution_Extension_Methods
{
    public class DebitAccount
    {
        public string AccountNumber { get; set; }
        public decimal Value { get; set; }
        public string TransactionNumber { get; set; }

        public string FormatTransaction()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            AccountNumber = new string(Enumerable.Repeat(chars, 15)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            // Transaction Number Formatted
            return TransactionNumber;
        }
    }
}