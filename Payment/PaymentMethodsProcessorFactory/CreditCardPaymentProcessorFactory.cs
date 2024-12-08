using Payment.Interfaces;
using Payment.PaymentMethods;

namespace Payment.PaymentProcessorFactory;

public class CreditCardPaymentProcessorFactory : IPaymentProcessorFactory
{
    public IPaymentProcessor CreatePaymentProcessor(decimal amount)
    {
        Console.WriteLine("CreditCard Payment With 2percent fee!");
        var credit = new CreditCard();
        credit.Pay(CalculateFee(amount));
        return credit;
    }

    private static decimal CalculateFee(decimal amount)
    {
        amount += amount * (decimal)0.02;
        return amount;
    }
}