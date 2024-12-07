using Payment.enumModel;
using Payment.interfaces;
using Payment.PaymentMethods;
using Payment.PaymentMethodsFactory;

namespace Payment.PaymentService
{
    public class PaymentService
    {
        public IPaymentProcessor DoPayment(PaymentType paymentType, decimal amount)
        {
            return paymentType switch
            {
                PaymentType.CreditCard => new CreditCardPaymentProcessorFactory().CalculateDiscount(amount),
                PaymentType.PayPal => new PayPalPaymentProcessorFactory().CalculateDiscount(amount),
                PaymentType.CryptoCurrency => new CryptoCurrencyPaymentProcessorFactory().CalculateDiscount(amount),
                _ => new UnsupportedPaymentProcessor(),
            };
        }
    }
}
