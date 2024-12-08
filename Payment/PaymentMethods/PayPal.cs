using Payment.Interfaces;

namespace Payment.PaymentMethods;

public class PayPal : IPaymentProcessor
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"{amount} paid by PayPal");
    }
}