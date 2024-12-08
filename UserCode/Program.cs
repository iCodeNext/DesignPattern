//#region Simple
//public class Program
//{
//    public static void Main()
//    {
//        var type = Console.ReadLine();

//        switch (type)
//        {
//            case "Air":
//                {
//                    Console.WriteLine("Send package by air ...");
//                    break;
//                }
//            case "Train":
//                {
//                    Console.WriteLine("Send package by Train ...");
//                    break;
//                }
//            default:
//                break;
//        }
//    }
//}
//#endregion



//#region 1.1

//public class Program
//{
//    public static void Main()
//    {
//        var type = Console.ReadLine();

//        switch (type)
//        {
//            case "Air":
//                {
//                    var instance = new Air();
//                    instance.SendByAir();
//                    break;
//                }
//            case "Train":
//                {
//                    var train = new Train();
//                    train.SendIt();
//                    break;
//                }
//            default:
//                break;
//        }
//    }
//}

//public class Air
//{
//    public void SendByAir()
//    {
//        Console.WriteLine("Send package by air ...");
//    }
//}

//public class Train
//{
//    public void SendIt()
//    {
//        Console.WriteLine("Send package by Train ...");
//    }
//}

//#endregion

//#region 1.2

//public class Program
//{
//    public static void Main()
//    {
//        var type = Console.ReadLine();
//        TransportService.Send(type);
//    }
//}

//public class TransportService
//{
//    public static void Send(string type)
//    {
//        switch (type)
//        {
//            case "Air":
//                {
//                    var instance = new Air();
//                    instance.SendByAir();
//                    break;
//                }
//            case "Train":
//                {
//                    var train = new Train();
//                    train.SendIt();
//                    break;
//                }
//            default:
//                break;
//        }
//    }
//}

//public class Air
//{
//    public void SendByAir()
//    {
//        Console.WriteLine("Send package by air ...");
//    }
//}

//public class Train
//{
//    public void SendIt()
//    {
//        Console.WriteLine("Send package by Train ...");
//    }
//}

//#endregion

//#region 1.3

//public class Program
//{
//    public static void Main()
//    {
//        var type = Console.ReadLine();
//        TransportService.Send(type);
//    }
//}

//public class TransportService
//{
//    public static void Send(string type)
//    {
//        switch (type)
//        {
//            case "Air":
//                {
//                    ITransport instance = new Air();
//                    instance.Send();
//                    break;
//                }
//            case "Train":
//                {
//                    ITransport train = new Train();
//                    train.Send();
//                    break;
//                }
//            default:
//                break;
//        }
//    }
//}

//public interface ITransport
//{
//    void Send();
//}

//public class Air : ITransport
//{
//    public void Send()
//    {
//        Console.WriteLine("Send package by air ...");
//    }
//}

//public class Train : ITransport
//{
//    public void Send()
//    {
//        Console.WriteLine("Send package by Train ...");
//    }
//}

//public class Truck : ITransport
//{
//    public void Send()
//    {
//        throw new NotImplementedException();
//    }
//}

//#endregion




//#region 1.4

//public class Program
//{
//    public static void Main()
//    {
//        var type = Console.ReadLine();
//        ITransport transport = TransportService.Create(type);
//        transport.Send();
//    }
//}

//public class TransportService
//{
//    public static ITransport Create(string type)
//    {
//        switch (type)
//        {
//            case "Air":
//                {
//                    return new Air();
//                }
//            case "Train":
//                {
//                    return new Train();
//                }
//            default:
//                throw new NotImplementedException();
//        }
//    }
//}

//public interface ITransport
//{
//    void Send();
//}

//public class Air : ITransport
//{
//    public void Send()
//    {
//        Console.WriteLine("Send package by air ...");
//    }
//}

//public class Train : ITransport
//{
//    public void Send()
//    {
//        Console.WriteLine("Send package by Train ...");
//    }
//}

//#endregion

//#region 1.5

//public class Program
//{
//    public static void Main()
//    {
//        var type = Console.ReadLine();
//        ITransport transport = TransportService.Create(type);
//        transport.Send();
//    }
//}

//public class TransportService
//{
//    public static ITransport Create(string type)
//    {
//        switch (type)
//        {
//            case "Air":
//                {
//                    var factory = new AirFactory();
//                    return factory.Create();
//                }
//            case "Train":
//                {
//                    var factory = new TrainFactory();
//                    return factory.CreateTrain();
//                }
//            default:
//                throw new NotImplementedException();
//        }
//    }
//}

//public interface ITransport
//{
//    void Send();
//}

//public class Air : ITransport
//{
//    public void Send()
//    {
//        Console.WriteLine("Send package by air ...");
//    }
//}

//public class Train : ITransport
//{
//    public void Send()
//    {
//        Console.WriteLine("Send package by Train ...");
//    }
//}

//public class AirFactory
//{
//    public ITransport Create()
//    {
//        //manage instance -> single
//        return new Air();
//    }
//}

//public class TrainFactory
//{
//    public ITransport CreateTrain()
//    {
//        //manage instance -> pool 
//        return new Train();
//    }
//}

//#endregion

//#region 1.6

//public class Program
//{
//    public static void Main()
//    {
//        var type = Console.ReadLine();
//        ITransport transport = TransportService.Create(type);
//        transport.Send();
//    }
//}

//public class TransportService
//{
//    public static ITransport Create(string type)
//    {
//        switch (type)
//        {
//            case "Air":
//                {
//                    var factory = new AirFactory();
//                    return factory.CreateInstance();
//                }
//            case "Train":
//                {
//                    var factory = new TrainFactory();
//                    return factory.CreateInstance();
//                }
//            case "Truck":
//                {
//                    var factory = new TruckFactory();
//                    return factory.CreateInstance();
//                }
//            default:
//                throw new NotImplementedException();
//        }
//    }
//}

//public interface ITransport
//{
//    void Send();
//}

//public class Air : ITransport
//{
//    public void Send()
//    {
//        Console.WriteLine("Send package by air ...");
//    }
//}

//public class Train : ITransport
//{
//    public void Send()
//    {
//        Console.WriteLine("Send package by Train ...");
//    }
//}

//public class Truck : ITransport
//{
//    public void Send()
//    {
//        Console.WriteLine("Send package by Truck ...");
//    }
//}


//public interface ITransportFactory
//{
//    ITransport CreateInstance();
//}

//public class AirFactory : ITransportFactory
//{
//    public ITransport CreateInstance()
//    {
//        manage instance
//        return new Air();
//    }
//}

//public class TrainFactory : ITransportFactory
//{
//    public ITransport CreateInstance()
//    {
//        manage instance
//        return new Train();
//    }
//}

//public class TruckFactory : ITransportFactory
//{
//    public ITransport CreateInstance()
//    {
//        manage instance
//        return new Truck();
//    }
//}

//#endregion

//#region 1.7

//public class Program
//{
//    public static void Main()
//    {
//        var type = Console.ReadLine();
//        ITransport transport = new TransportService("Truck", new TruckFactory())
//                                    .Create(type);
//        transport.Send();
//    }
//}

//#region ...dll

//public class TransportService
//{
//    Dictionary<string, ITransportFactory> _factories = [];
//    public TransportService()
//    {
//        _factories.Add("Air", new AirFactory());
//        _factories.Add("Train", new TrainFactory());
//    }

//    public TransportService(string type, ITransportFactory transportFactory)
//    {
//        _factories.Add(type, transportFactory);
//    }

//    public ITransport Create(string type)
//    {
//        return _factories[type].CreateInstance();
//    }
//}

//public interface ITransport
//{
//    void Send();
//}

//public class Air : ITransport
//{
//    public void Send()
//    {
//        Console.WriteLine("Send package by air ...");
//    }
//}

//public class Train : ITransport
//{
//    public void Send()
//    {
//        Console.WriteLine("Send package by Train ...");
//    }
//}



//public interface ITransportFactory
//{
//    ITransport CreateInstance();
//}

//public class AirFactory : ITransportFactory
//{
//    public ITransport CreateInstance()
//    {
//        //manage instance
//        return new Air();
//    }
//}

//public class TrainFactory : ITransportFactory
//{
//    public ITransport CreateInstance()
//    {
//        //manage instance
//        return new Train();
//    }
//}


//#endregion

//public class TruckFactory : ITransportFactory
//{
//    public ITransport CreateInstance()
//    {
//       return new Truck();
//    }
//}

//public class Truck : ITransport
//{
//    public void Send()
//    {
//        throw new NotImplementedException();
//    }
//}

//#endregion


//#region 1.8

//using CryptoCurrencyExternalLibrary;
//using ExternalClassLibrary;
//using System.ComponentModel;

//public class Program
//{
//    public static void Main()
//    {
//        var type = Console.ReadLine();
//        ITransport transport = TransportService.Create(type);
//        transport.Send();
//    }
//}

//public class TransportService
//{
//    public static ITransport Create(string type)
//    {
//        switch (type)
//        {
//            case "Air":
//                {
//                    var factory = new AirFactory();
//                    return factory.CreateInstance();
//                }
//            case "Train":
//                {
//                    var factory = new TrainFactory();
//                    return factory.CreateInstance();
//                }

//            case "Truck":
//                {
//                    return new TruckAdapter();
//                }
//            default:
//                throw new NotImplementedException();
//        }
//    }
//}

//public interface ITransport
//{
//    void Send();
//}

//public class Air : ITransport
//{
//    public void Send()
//    {
//        Console.WriteLine("Send package by air ...");
//    }
//}

//public class Train : ITransport
//{
//    public void Send()
//    {
//        Console.WriteLine("Send package by Train ...");
//    }
//}

//public class TruckAdapter : ITransport
//{
//    private readonly Truck _truck;

//    public TruckAdapter()
//    {
//        _truck = new Truck(5, "THR");
//    }

//    public void Send()
//    {
//        // Delegate the call to the Truck class's Deliver method
//        // string -> xml nodes
//        // <xml>
//        // <node>............</node>
//        //</xml>
//        _truck.Deliver();
//    }
//}

//public interface ITransportFactory
//{
//    ITransport CreateInstance();
//}

//public class AirFactory : ITransportFactory
//{
//    public ITransport CreateInstance()
//    {
//        //manage instance
//        return new Air();
//    }
//}

//public class TrainFactory : ITransportFactory
//{
//    public ITransport CreateInstance()
//    {
//        //manage instance
//        return new Train();
//    }
//}

//#endregion
#region 1.9

using CryptoCurrencyExternalLibrary;


public class Program
{
    public static void Main()
    {
        var type = Console.ReadLine();
        Console.WriteLine("Please enter the amount:");

        string input = Console.ReadLine();
        if (decimal.TryParse(input, out decimal amount))
        {
            Console.WriteLine($"The entered amount is: {amount}"); // You can now use the 'amount' variable as needed

        }
        else
        {
            Console.WriteLine("Invalid input, please enter a valid decimal number.");
        }


        IPayment payment = PaymentService.Create(type);
        payment.ProcessPayment(amount);
        amount = payment.AdjustAmount(amount);
    }
}

public class PaymentService
{
    public static IPayment Create(string type)
    {
        switch (type)
        {
            case "CreditCard":
                {
                    var factory = new CreditCardFactory();
                    return factory.CreateInstance();
                }
            case "PayPal":
                {
                    var factory = new PayPalFactory();
                    return factory.CreateInstance();
                }

            case "CryptoCurrency":
                {
                    return new CryptoCurrencyAdapter();
                }
            default:
                {
                    var factory = new NullPaymentFactory();
                    return factory.CreateInstance();
                }
        }
    }
}

public interface IPayment
{
    void ProcessPayment(decimal amount);
    decimal AdjustAmount(decimal amount);

}
public class CreditCard : IPayment
{
    private const decimal FeeRate = 0.02m;
    public void ProcessPayment(decimal amount)
    {

    }
    public decimal AdjustAmount(decimal amount)
    {
        return amount + (amount * FeeRate);
    }

}

public class PayPal : IPayment
{
    private const decimal DiscountRate = 0.03m;
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine();
    }
    public decimal AdjustAmount(decimal amount)
    {
        return amount - (amount * DiscountRate);
    }
}

public class CryptoCurrencyAdapter : IPayment
{
    private readonly CryptoCurrency _cryptoCurrency;

    public CryptoCurrencyAdapter()
    {
        _cryptoCurrency = new CryptoCurrency();
    }

    public decimal AdjustAmount(decimal amount)
    {
        return _cryptoCurrency.ExternalProcessPayment(amount);
    }

    public void ProcessPayment(decimal amount)
    {
        throw new NotImplementedException();
    }
}

public interface IPaymentFactory
{
    IPayment CreateInstance();
}

public class CreditCardFactory : IPaymentFactory
{
    public IPayment CreateInstance()
    {
        //manage instance
        return new CreditCard();
    }
}

public class PayPalFactory : IPaymentFactory
{
    public IPayment CreateInstance()
    {
        //manage instance
        return new PayPal();
    }
}

public class NullPayment : IPayment
{
    public decimal AdjustAmount(decimal amount)
    {
        return amount;
    }

    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Payment method not supported. Unable to process ${amount:F2}.");
    }

}
public class NullPaymentFactory : IPaymentFactory
{
    public IPayment CreateInstance()
    {
        //manage instance
        return new NullPayment();
    }
}


#endregion