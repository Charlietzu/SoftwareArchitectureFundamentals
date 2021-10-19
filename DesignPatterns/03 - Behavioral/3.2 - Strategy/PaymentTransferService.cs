using System;
using System.Linq;

namespace DesignPatterns
{
    public class PaymentTransferService : IPayment
    {
        private readonly IPaymentTransferFacade _paymentTransferFacade;

        public PaymentTransferService(IPaymentTransferFacade paymentTransferFacade)
        {
            _paymentTransferFacade = paymentTransferFacade;
        }

        public Payment MakePayment(Order order, Payment payment)
        {
            payment.Value = order.Products.Sum(p => p.Value);
            Console.WriteLine("Starting Payment via Bank Transfer - Value R$ " + payment.Value);

            payment.TransferConfirmation = _paymentTransferFacade.PerformTransfer();
            payment.Status = "Paid via Bank Transfer";
            return payment;
        }
    }
}