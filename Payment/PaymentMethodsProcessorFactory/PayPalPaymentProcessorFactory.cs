using Payment.Interfaces;
using Payment.PaymentMethods;

namespace Payment.PaymentProcessorFactory;

public class PayPalPaymentProcessorFactory : IPaymentProcessorFactory
{
    public IPaymentProcessor CreatePaymentProcessor(decimal amount)
    {
        var paypal = new PayPal();
        paypal.Pay(amount);
        return paypal;
    }
}