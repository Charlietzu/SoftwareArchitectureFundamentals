using System;

namespace DesignPatterns
{
    public class PaymentFactory
    {
        // In this case it would be necessary to use a type of Service Locator
        // Or inject all instances to return just one
        public static IPayment CreatePayment(PaymentMethod paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethod.CreditCard:
                    return new CreditCardPaymentService(
                               new CreditCardPaymentFacade(
                               new PayPalGateway(),
                               new ConfigurationManager()));

                case PaymentMethod.PaymentSlip:
                    return new PaymentSlipService(new PaymentSlipFacade());

                case PaymentMethod.BankTransfer:
                    return new PaymentTransferService(new PaymentTransferFacade());

                default:
                    throw new ApplicationException("Payment method unknown");
            }
        }
    }
}