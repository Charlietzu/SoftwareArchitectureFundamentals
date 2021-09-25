namespace SOLID.OCP.Solution_Extension_Methods
{
    public static class DebitCheckingAccount
    {
        public static string PerformDebitCheckingAccount(this DebitAccount debitAccount)
        {
            // Business logic for debiting an checking account.
            return debitAccount.FormatTransaction();
        }
    }
}