using System;
using System.Linq;

namespace DesignPatterns
{
    public class PaymentTransferFacade : IPaymentTransferFacade
    {
        public string PerformTransfer()
        {
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}