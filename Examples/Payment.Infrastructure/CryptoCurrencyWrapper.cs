using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExternalClassLibrary;
using Payment.Core;

namespace Payment.Infrastructure
{
    public class CryptoCurrencyWrapper : IPaymentProcessor
    {
        private static Lazy<CryptoCurrency> _cryptoLazy = new Lazy<CryptoCurrency>(new CryptoCurrency());
        public void Process(float price)
        {
            _cryptoLazy.Value.ProcessOrder(price);
        }
    }
}
