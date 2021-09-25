namespace SOLID.OCP.Solution
{
    public class DebitSavingsAccount : DebitAccount
    {
        public override string Debit(decimal value, string account)
        {
            // Validate Account Registration Date
            // Debit Savings Account
            return FormatTransaction();
        }
    }
}