namespace DesignPatterns
{
    public class Payment
    {
        public string Status { get; set; }
        public decimal Value { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string CreditCard { get; set; }
        public string PaymentSlipCode { get; set; }
        public string TransferConfirmation { get; set; }
    }
}
