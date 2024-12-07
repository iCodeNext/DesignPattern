using Payment.CryptoAdapter;
using Payment.interfaces;

namespace Payment.PaymentMethodsFactory
{
    public class CryptoCurrencyPaymentProcessorFactory : IPaymentProcessorFactory
    {
        public IPaymentProcessor CalculateDiscount(decimal amount)
        {
            var crypto = new CryptoCurrencyPaymentProcessorAdapter(new CryptoPaymentDll());
            crypto.Pay(amount);
            return crypto;
        }
    }
}
