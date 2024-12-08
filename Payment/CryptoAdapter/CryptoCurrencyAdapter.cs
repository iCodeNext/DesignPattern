using Payment.Interfaces;

namespace Payment.CryptoAdapter;

public class CryptoCurrencyAdapter : IPaymentProcessor
{
    private readonly CryptoDll _cryptoDll;

    public CryptoCurrencyAdapter(CryptoDll cryptoDll)
    {
        _cryptoDll = cryptoDll;
    }

    public void Pay(decimal amount)
    {
        _cryptoDll.Payment(amount);
    }
}