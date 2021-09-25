namespace SOLID.OCP.Solution_Extension_Methods
{
    public static class DebitInvestmentAccount
    {
        public static string PerformDebitInvestmentAccount(this DebitAccount debitAccount)
        {
            // Business logic for debiting an investment account.
            return debitAccount.FormatTransaction();
        }
    }
}