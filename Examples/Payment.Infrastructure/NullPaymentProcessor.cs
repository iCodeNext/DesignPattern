using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payment.Core;

namespace Payment.Infrastructure
{
    public class NullPaymentProcessor : IPaymentProcessor
    {
        public void Process(float price)
        {
            Console.WriteLine("No adjustment for the selected payment method.");
            Console.WriteLine($"Payment method not supported. Unable to process ${price}");
        }
    }
}
