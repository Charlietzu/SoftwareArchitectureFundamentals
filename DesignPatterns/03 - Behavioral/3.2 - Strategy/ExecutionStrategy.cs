using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class ExecutionStrategy
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

            Payment creditPaymentMethod = new Payment
            {
                PaymentMethod = PaymentMethod.CreditCard,
                CreditCard = "5555 2222 5555 9999"
            };

            Payment slipPaymentMethod = new Payment
            {
                PaymentMethod = PaymentMethod.PaymentSlip
            };

            Payment transferPaymentMethod = new Payment
            {
                PaymentMethod = PaymentMethod.BankTransfer,
                CreditCard = "5555 2222 5555 9999"
            };

            OrderService orderCredit = new OrderService(PaymentFactory.CreatePayment(creditPaymentMethod.PaymentMethod));
            Payment paymentCredit = orderCredit.MakePayment(order, creditPaymentMethod);
            Console.WriteLine(paymentCredit.Status);

            Console.WriteLine("-------------------------------------------------------");

            OrderService orderSlip = new OrderService(PaymentFactory.CreatePayment(slipPaymentMethod.PaymentMethod));
            Payment paymentSlip = orderSlip.MakePayment(order, slipPaymentMethod);
            Console.WriteLine(paymentSlip.Status);

            Console.WriteLine("-------------------------------------------------------");

            OrderService orderTransfer = new OrderService(PaymentFactory.CreatePayment(transferPaymentMethod.PaymentMethod));
            Payment paymentTransfer = orderTransfer.MakePayment(order, transferPaymentMethod);
            Console.WriteLine(paymentTransfer.Status);
        }
    }
}