using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class ExecutionFacade
    {
        public static void Execute()
        {
            List<Product> products = new List<Product>
            {
                new Product{Name = "Adidas Sneakers", Value = new Random().Next(500)},
                new Product{Name = "Bowling Shirt", Value = new Random().Next(500)},
                new Product{Name = "Tennis Racket", Value = new Random().Next(500)}
            };

            Order order = new Order
            {
                Id = Guid.NewGuid(),
                Products = products
            };

            Payment payment = new Payment
            {
                CreditCard = "5555 2222 5555 9999"
            };

            CreditCardPaymentService paymentService = new CreditCardPaymentService(new CreditCardPaymentFacade(new PayPalGateway(), new ConfigurationManager()));

            Payment paymentResult = paymentService.MakePayment(order, payment);

            Console.WriteLine(paymentResult.Status);
        }
    }
}
