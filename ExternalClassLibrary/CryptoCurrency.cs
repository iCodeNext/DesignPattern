using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalClassLibrary
{
    // External Dependency ==> CryptoCurrency.dll
    public class CryptoCurrency
    {
        public void ProcessOrder(float price)
        {
            Console.WriteLine("No adjustment for the selected payment method.");
            Console.WriteLine($"Processing cryptocurrency payment of ${price} via third-party library");
        }
    }
}
