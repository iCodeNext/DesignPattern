
Console.WriteLine("Enter payment method:");

var paymentMethodInput = Console.ReadLine();
PaymentMethod paymentMethod;

if (!Enum.TryParse(paymentMethodInput, true, out paymentMethod))
{
    paymentMethod = PaymentMethod.Unsupported;
}

Console.WriteLine("Enter payment amount:");

var amountInput = Console.ReadLine();


if (decimal.TryParse(amountInput, out decimal amount))
{
    var factory = new PaymentProcessorFactory();
    IPaymentProcessor processor = factory.GetPaymentProcessor(paymentMethod);
    processor.ProcessPayment(amount);
}

public class PaymentProcessorFactory
{
    public IPaymentProcessor GetPaymentProcessor(PaymentMethod paymentMethod)
    {
        return paymentMethod switch
        {
            PaymentMethod.CreditCard => new CreditCardPaymentProcessor(),
            PaymentMethod.PayPal => new PayPalPaymentProcessor(),
            PaymentMethod.CryptoCurrency => new CryptoCurrencyPaymentAdapter(new CryptoCurrencyPaymentProcessor()),
            _ => new NullPaymentProcessor()
        };
    }
}

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
    decimal ApplyAdjustment(decimal amount)
    {
        return amount;
    }
}

public class CreditCardPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        var adjustedAmount = ApplyAdjustment(amount);
        Console.WriteLine($"Processing credit card payment of {adjustedAmount:C}");
    }

    public decimal ApplyAdjustment(decimal amount)
    {
        return amount * 1.02m;
    }
}

public class PayPalPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        var adjustedAmount = ApplyAdjustment(amount);
        Console.WriteLine($"Processing PayPal payment of {adjustedAmount:C}");
    }

    public decimal ApplyAdjustment(decimal amount)
    {
        return amount * 1.03m;
    }
}

public class CryptoCurrencyPaymentProcessor
{
    public void ProcessCryptoPayment(decimal amount)
    {
        Console.WriteLine($"Processing cryptocurrency payment of {amount:C} via third-party library.");
    }
}

public class CryptoCurrencyPaymentAdapter(CryptoCurrencyPaymentProcessor cryptoPaymentProcessor) : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        cryptoPaymentProcessor.ProcessCryptoPayment(amount);
    }
}

public class NullPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Payment method not supported. Unable to process {amount:C}.");
    }
}

public enum PaymentMethod
{
    CreditCard,
    PayPal,
    CryptoCurrency,
    Unsupported
}

