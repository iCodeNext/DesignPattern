using Payment.interfaces;
using Payment.PaymentMethods;

namespace Payment.PaymentMethodsFactory
{
    public class UnsupportedPaymentProcessorFactory : IPaymentProcessorFactory
    {
        public IPaymentProcessor CalculateDiscount(decimal amount)
        {
            var Unsupported = new UnsupportedPaymentProcessor();
            Unsupported.Pay(amount);
            return Unsupported;
        }
    }
}
