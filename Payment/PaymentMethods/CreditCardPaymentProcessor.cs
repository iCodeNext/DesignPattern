using Payment.interfaces;

namespace Payment.PaymentMethods
{
    public class CreditCardPaymentProcessor : IPaymentProcessor
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of ${amount}.");
        }
    }
}
