using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payment.Core;

namespace Payment.Infrastructure
{
    public class CreditCard : IPaymentProcessor
    {
        public void Process(float price)
        {
            price = price + (price * 2) / 100;
            Console.WriteLine("Applying 2% fee for credit card payment");
            Console.WriteLine($"Processing credit card payment of ${price}");
        }
    }
}
