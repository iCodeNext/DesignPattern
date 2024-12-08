using Payment.Interfaces;
using Payment.PaymentMethods;

namespace Payment.PaymentProcessorFactory;

public class UnsupportedPaymentMethodFactory : IPaymentProcessorFactory
{
    public IPaymentProcessor CreatePaymentProcessor(decimal amount)
    {
        var unsapported = new UnsupportedPaymentMethod();
        unsapported.Pay(amount);
        return unsapported;
    }
}