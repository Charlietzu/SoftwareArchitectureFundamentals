namespace DesignPatterns
{
    public class CreditCardPaymentFacade : ICreditCardPaymentFacade
    {
        private readonly IPayPalGateway _payPalGateway;
        private readonly IConfigurationManager _configManager;
        public CreditCardPaymentFacade(IPayPalGateway payPalGateway, IConfigurationManager configManager)
        {
            _payPalGateway = payPalGateway;
            _configManager = configManager;
        }
        public bool MakePayment(Order order, Payment payment)
        {
            string apiKey = _configManager.GetValue("apiKey");
            string encriptionKey = _configManager.GetValue("encriptionKey");

            string serviceKey = _payPalGateway.GetPayPalServiceKey(apiKey, encriptionKey);
            string cardHashKey = _payPalGateway.GetCardHashKey(serviceKey, payment.CreditCard);

            bool pagamentoResult = _payPalGateway.CommitTransaction(cardHashKey, order.Id.ToString(), payment.Value);

            return pagamentoResult;
        }
    }
}
