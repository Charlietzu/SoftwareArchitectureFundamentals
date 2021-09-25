namespace SOLID.OCP.Solution
{
    public class DebitCheckingAccount : DebitAccount
    {
        public override string Debit(decimal value, string account)
        {
            // Debit Checking Account
            return FormatTransaction();
        }
    }
}