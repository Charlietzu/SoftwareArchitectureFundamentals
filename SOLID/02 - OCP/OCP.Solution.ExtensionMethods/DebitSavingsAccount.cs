namespace SOLID.OCP.Solution_Extension_Methods
{
    public static class DebitSavingsAccount
    {
        public static string PerformDebitSavingsAccount(this DebitAccount debitAccount)
        {
            // Business logic for debiting an savings account.
            return debitAccount.FormatTransaction();
        }
    }
}