using Payment.interfaces;
using Payment.PaymentMethods;

namespace Payment.PaymentMethodsFactory
{
    public class PayPalPaymentProcessorFactory : IPaymentProcessorFactory
    {
        public IPaymentProcessor CalculateDiscount(decimal amount)
        {
            var PayPal = new PayPalPaymentProcessor();
            PayPal.Pay(amount);
            return PayPal;
        }
    }
}
