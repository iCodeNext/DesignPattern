using Payment.interfaces;

namespace Payment.PaymentMethods
{
    public class UnsupportedPaymentProcessor : IPaymentProcessor
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("No adjustment for the selected payment method.");
            Console.WriteLine($"Payment method not supported. Unable to process ${amount}.");
        }
    }
}
