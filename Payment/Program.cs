// See https://aka.ms/new-console-template for more information

using Payment;
using Payment.Enum;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        new PaymentService().PaymentProcessor(PaymentType.PayPal, 100);
        new PaymentService().PaymentProcessor(PaymentType.CreditCard, 100);
        new PaymentService().PaymentProcessor(PaymentType.CryptoCurrency, 100);
    }
}