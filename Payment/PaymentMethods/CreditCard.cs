using Payment.Interfaces;

namespace Payment.PaymentMethods;

public class CreditCard : IPaymentProcessor
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"amount: {amount} Payed on CreditCard");
    }
}