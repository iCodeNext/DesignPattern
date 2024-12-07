using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Payment
{
    public enum PaymetType
    {
        CreditCard,
        PayPal,
        CryptoCurrency
    }
    public class Ecommerce
    {
        public void Pay(PaymetType paymetType, decimal amount)
        {
            switch (paymetType)
            {
                case PaymetType.CreditCard:
                    new CreditCardProcessor().Pay(amount);
                    break;
                case PaymetType.PayPal:
                    new PayPalProcessor().Pay(amount);
                    break;
                case PaymetType.CryptoCurrency:
                    new CryptoAdapter(new CryptoCurrencyProcessor()).Pay(amount);
                    break;
                default: throw new Exception("NullPaymentProcessor");
            }
        }


        interface IPaymentProcessor
        {
            public void Pay(decimal amount);
        }

        public class CreditCardProcessor : IPaymentProcessor
        {
            public void Pay(decimal amonut)
            {
                Console.WriteLine(amonut + (2 * amonut / 100));
            }
        }

        public class PayPalProcessor : IPaymentProcessor
        {
            public void Pay(decimal amonut)
            {
                throw new NotImplementedException();
            }
        }


        // Supppose this class comes from a third party library
        #region CryptoCurrencyProcessor
        public interface ICryptoCurrencyProcessor
        {
            public bool PayByCrypto(decimal amount);
        }
        public class CryptoCurrencyProcessor : ICryptoCurrencyProcessor
        {
            public bool PayByCrypto(decimal amonut)
            {
                throw new NotImplementedException();
            }
        }
        #endregion


        // The CryptoAdapter makes the CryptoCurrencyProcessor compatible with the PaymentProcessor interface
        class CryptoAdapter : IPaymentProcessor
        {
            private readonly CryptoCurrencyProcessor _cryptoCurrencyProcessor;

            public CryptoAdapter(CryptoCurrencyProcessor cryptoCurrencyProcessor)
            {
                _cryptoCurrencyProcessor = cryptoCurrencyProcessor;
            }

            public void Pay(decimal amonut)
            {
                _cryptoCurrencyProcessor.PayByCrypto(amonut);
            }
        }

    }
}
