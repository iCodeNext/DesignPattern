using Payment.ThirdParty;

namespace Payment;
public interface IPaymentProcessor
{
    decimal Amount;
    void CalculatePayment(decimal amount);
    void SendMessage();
}
public class CreditCardProcessor : IPaymentProcessor 
{
    public decimal Amount { get; set; }
    public void CalculatePayment(decimal amount) 
    {
        Amount= amount + (0 / 02 * amount)
    }
    public void SendMessage() 
    {
        Console.WriteLine("Applying 2% fee for credit card payment.");
        Console.WriteLine($"Processing credit card payment of $" +{ Amount});
    }
}

public class PayPalProcessor : IPaymentProcessor
{
    public decimal Amount { get; set; }
    public void CalculatePayment(decimal amount)
    {
        Amount= amount;
    }
    public void SendMessage()
    {
        Console.WriteLine($"Processing PayPal payment of $" +{ Amount});
    }
}

public class NullPaymentProcessor : IPaymentProcessor
{
    public decimal Amount { get; set; }
    public void CalculatePayment(decimal amount)
    {
      Amount = amount;
    }
    public void SendMessage()
    {
        Console.WriteLine("No adjustment for the selected payment method.");
        Console.WriteLine($"Payment method not supported. Unable to process $" +{ Amount});
    }
}
public class CryptoCurrencyProcessorAdopter: IPaymentProcessor
{
    public CryptoCurrencyProcessor _cryptoCurrencyProcessor = new CryptoCurrencyProcessor();
    public decimal Amount { get; set; }
    public void CalculatePayment(decimal amount)
    {
        Amount = _cryptoCurrencyProcessor.SetPaymentAmount(amount);
    }
    public void SendMessage()
    {
        Console.WriteLine("No adjustment for the selected payment method.");
        Console.WriteLine($"Processing cryptocurrency payment of $" +{ Amount}+" via third-party library");
    }
}

public static class PaymentProcessorFactory
{
    public static IPaymentProcessor GetPaymentProcessor(string paymentMethod)
    {
        return paymentMethod.ToLower() switch
        {
            "creditcard" => new CreditCardPaymentProcessor(),
            "paypal" => new PayPalPaymentProcessor(),
            "cryptocurrency" => new CryptoCurrencyPaymentProcessor(),
            _ => new NullPaymentProcessor(),
        };
    }
}
class Program
{
    static void Main(string[] args)
    {
        ProcessOrder("CreditCard", 100);
        ProcessOrder("CryptoCurrency", 200);
        ProcessOrder("Unsupported", 150);
    }

    static void ProcessOrder(string paymentMethod, decimal amount)
    {
        var processor = PaymentProcessorFactory.GetPaymentProcessor(paymentMethod);
        processor.CalculatePayment(amount);
        processor.SendMessage();
    }
}
namespace ThirdParty;
public class CryptoCurrencyProcessor
{
    public decimal SetPaymentAmount(decimal amount)
    {
        return (decimal)amount;
    }
}