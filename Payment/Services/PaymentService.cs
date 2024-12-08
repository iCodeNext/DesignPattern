using Payment.CryptoAdapter;
using Payment.Enum;
using Payment.Interfaces;
using Payment.PaymentMethods;
using Payment.PaymentProcessorFactory;

namespace Payment;

public class PaymentService
{
    public IPaymentProcessor PaymentProcessor(PaymentType paymentType, decimal amount)
    {
        return paymentType switch
        {
            PaymentType.CreditCard => new CreditCardPaymentProcessorFactory().CreatePaymentProcessor(amount),
            PaymentType.PayPal => new PayPalPaymentProcessorFactory().CreatePaymentProcessor(amount),
            PaymentType.CryptoCurrency => new CryptoCurrencyPaymentProcessorFactory().CreatePaymentProcessor(amount),
            _ => new UnsupportedPaymentMethod()
        };
    }
}