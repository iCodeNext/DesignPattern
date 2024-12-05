// See https://aka.ms/new-console-template for more information

Console.WriteLine("Transfer By Which type : ");

var factory = new PaymentFactory();
factory.AddFactory("Crypto", new CryptoCurrencyAdaptor());

var type = Console.ReadLine();

while (!string.IsNullOrEmpty(type))
{
    var paymentService = factory.Create(type);
    var amount = paymentService.Transfer(100);
    Console.WriteLine("amount is : {0} ", amount);
    Console.WriteLine("Transfer By Which type : ");

    type = Console.ReadLine();
}

#region thirdParty cryptoCurrency
public class CryptoCurrency
{
    public double Pay(double amount, long fee)
    {
        var amountPay = amount + fee * amount / 100;
        return amountPay;
    }
}

#endregion// object adaptor

#region CryptoAdaptor
public class CryptoCurrencyAdaptor : PaymentBaseService
{
    private CryptoCurrency cryptoCurrency = new CryptoCurrency();
    public override decimal Transfer(decimal amount)
    {
        var doubleAmount = Convert.ToDouble(amount);

        var result = cryptoCurrency.Pay(doubleAmount, fee);

        return Convert.ToDecimal(result);
    }
}

#endregion
#region PaymentLibrary
public class PaymentFactory
{
    private Dictionary<string, PaymentBaseService> factories = [];
    public PaymentFactory()
    {
        factories.Add("CreditCard", new CreditCardPayment());
        factories.Add("PayPal", new PayPalPayment());
        factories.Add("UnSupported", new UnSupportedPayment());
    }
    public void AddFactory(string type, PaymentBaseService paymentService)
    {
        if (!factories.ContainsKey(type))
            factories.Add(type, paymentService);
    }
    public PaymentBaseService Create(string paymentType)
    {
        if (factories.ContainsKey(paymentType))
            return factories[paymentType];

        return factories["UnSupported"];
    }
}
public abstract class PaymentBaseService
{
    public virtual int fee => 0;
    public decimal MeasureAmount(decimal amount)
    {
        return amount + fee * amount / 100;
    }
    public abstract decimal Transfer(decimal amount);
}
public class PayPalPayment : PaymentBaseService
{
    public override int fee { get => 2; }

    public override decimal Transfer(decimal amount)
    {
        var paymentAmount = MeasureAmount(amount);
        // transfer paymentAmount using Pay pal
        return paymentAmount;
    }
}

public class CreditCardPayment : PaymentBaseService
{
    public override decimal Transfer(decimal amount)
    {
        var paymentAmount = MeasureAmount(amount);
        // transfer paymentAmount using CreditCard
        return paymentAmount;
    }
}
public class UnSupportedPayment : PaymentBaseService
{
    public override decimal Transfer(decimal amount)
    {
        // Log
        Console.WriteLine("Unsupported payment method selected.");
        return amount;
    }
}

#endregion