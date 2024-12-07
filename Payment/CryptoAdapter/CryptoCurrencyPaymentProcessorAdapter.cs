using Payment.interfaces;

namespace Payment.CryptoAdapter
{
    public class CryptoCurrencyPaymentProcessorAdapter : IPaymentProcessor
    {
        private readonly CryptoPaymentDll _cryptoPaymentDll;
        public CryptoCurrencyPaymentProcessorAdapter(CryptoPaymentDll cryptoPaymentDll)
        {
            _cryptoPaymentDll = cryptoPaymentDll;
        }

        public void Pay(decimal amount)
        {
            _cryptoPaymentDll.Payment(amount);
        }
    }
}
