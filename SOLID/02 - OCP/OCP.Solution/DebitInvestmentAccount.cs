namespace SOLID.OCP.Solution
{
    public class DebitInvestmentAccount : DebitAccount
    {
        public override string Debit(decimal value, string account)
        {
            // Debit Investment Account
            // Exempt Fees
            return FormatTransaction();
        }
    }
}