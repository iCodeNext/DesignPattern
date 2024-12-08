using Payment.Interfaces;

namespace Payment.PaymentMethods;

public class UnsupportedPaymentMethod : IPaymentProcessor
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"""
                          There is no payment available for this payment method.
                          {amount} is not paid!
                          """);
    }
}