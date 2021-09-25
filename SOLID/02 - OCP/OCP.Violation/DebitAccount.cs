namespace SOLID.OCP.Violation
{
    public class DebitAccount
    {
        public void Debit(decimal value, string account, AccountType accountType)
        {
            if (accountType == AccountType.Checking)
            {
                // Debit Checking Account
            }

            if (accountType == AccountType.Savings)
            {
                // Validate Account Registration Date
                // Debit Savings Account
            }
        }
    }
}