using System;
using System.Linq;

namespace DesignPatterns
{
    public class PaymentSlipService : IPayment
    {
        private readonly IPaymentSlipFacade _paymentSlipFacade;

        public PaymentSlipService(IPaymentSlipFacade paymentSlipFacade)
        {
            _paymentSlipFacade = paymentSlipFacade;
        }

        public Payment MakePayment(Order order, Payment payment)
        {
            payment.Value = order.Products.Sum(p => p.Value);
            Console.WriteLine("Starting Payment via Slip - Value R$ " + payment.Value);

            payment.PaymentSlipCode = _paymentSlipFacade.GenerateSlip();
            payment.Status = "Awaiting Payment";
            return payment;
        }
    }
}