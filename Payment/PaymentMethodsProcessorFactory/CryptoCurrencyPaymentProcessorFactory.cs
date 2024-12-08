using Payment.CryptoAdapter;
using Payment.Interfaces;

namespace Payment.PaymentProcessorFactory;

public class CryptoCurrencyPaymentProcessorFactory : IPaymentProcessorFactory
{
    public IPaymentProcessor CreatePaymentProcessor(decimal amount)
    {
        var crypto = new CryptoCurrencyAdapter(new CryptoDll());
        crypto.Pay(amount);
        return crypto;
    }
}