using Payment.interfaces;

namespace Payment.PaymentMethods
{
    public class PayPalPaymentProcessor : IPaymentProcessor
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("Done.");
        }
    }
}
