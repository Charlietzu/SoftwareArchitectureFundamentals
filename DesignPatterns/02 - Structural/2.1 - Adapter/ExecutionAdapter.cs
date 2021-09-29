namespace DesignPatterns
{
    public class ExecutionAdapter
    {
        public static void Execute()
        {
            TransactionService paymentDefaultLog = new TransactionService(new Logger());
            paymentDefaultLog.PerformTransaction();

            TransactionService paymentCustomLog = new TransactionService(new LogAdapter(new LogNetMasterService()));
            paymentCustomLog.PerformTransaction();
        }
    }
}