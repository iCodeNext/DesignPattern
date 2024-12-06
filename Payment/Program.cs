public class Program
{
    public static void Main()
    {
        ProcessPayment("CreditCard", 100);
        ProcessPayment("CryptoCurrency", 200);
        ProcessPayment("Unsupported", 150);
    }

    static void ProcessPayment(string paymentMethod, decimal amount)
    {
        IPaymentProcessor processor = PaymentService.Create(paymentMethod);
        processor.ProcessPayment(amount);
    }
}


public class PaymentService
{
    public static IPaymentProcessor Create(string paymentMethod)
    {

        return paymentMethod switch
        {
            "CreditCard" => new CreditCard(),
            "PayPal" => new PayPal(),
            "CryptoCurrency" => new CryptoCurrencyAdapter(),
            _ => new NullPaymentProcessor(),
        };
    }
}

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}

public class CreditCard : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        decimal adjustedAmount = amount + (amount * 0.02m); // 2% fee
        Console.WriteLine($"Applying 2% fee for credit card payment.");
        Console.WriteLine($"Processing credit card payment of ${adjustedAmount:F2}");
    }
}
public class PayPal : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        decimal adjustedAmount = amount - (amount * 0.05m); // 5% discount
        Console.WriteLine($"Applying 5% discount for PayPal payment.");
        Console.WriteLine($"Processing PayPal payment of ${adjustedAmount:F2}");
    }
}

// Adapter for CryptoCurrency
public class CryptoCurrencyAdapter : IPaymentProcessor
{
    private readonly ThirdPartyCryptoProcessor _thirdPartyCryptoProcessor;

    public CryptoCurrencyAdapter()
    {
        _thirdPartyCryptoProcessor = new ThirdPartyCryptoProcessor();
    }

    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"No adjustment for the selected payment method.");
        _thirdPartyCryptoProcessor.ProcessCryptoPayment(amount);
    }
}

// NullPaymentProcessor for unsupported methods
public class NullPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"No adjustment for the selected payment method.");
        Console.WriteLine($"Payment method not supported. Unable to process ${amount:F2}.");
    }
}

// Third-party crypto library
public class ThirdPartyCryptoProcessor
{
    public void ProcessCryptoPayment(decimal amount)
    {
        Console.WriteLine($"Processing cryptocurrency payment of ${amount:F2} via third-party library.");
    }
}







