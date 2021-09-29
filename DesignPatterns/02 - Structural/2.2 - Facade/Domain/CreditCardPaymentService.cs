using System;
using System.Linq;

namespace DesignPatterns
{
    public class CreditCardPaymentService : IPayment
    {
        private readonly ICreditCardPaymentFacade _creditCardPaymentFacade;

        public CreditCardPaymentService(ICreditCardPaymentFacade creditCardPaymentFacade)
        {
            _creditCardPaymentFacade = creditCardPaymentFacade;
        }

        public Payment MakePayment(Order order, Payment payment)
        {
            payment.Value = order.Products.Sum(p => p.Value);
            Console.WriteLine("Starting Credit Card Payment - Value R$ " + payment.Value);

            if (_creditCardPaymentFacade.MakePayment(order, payment))
            {
                payment.Status = "Paid by Credit Card";
                return payment;
            }

            payment.Status = "Credit Card Refused!";
            return payment;
        }
    }
}
