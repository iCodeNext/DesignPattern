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


#region 1.8

using ExternalClassLibrary;

public class Program
{
    public static void Main()
    {
        var type = Console.ReadLine();
        ITransport transport = TransportService.Create(type);
        transport.Send();
    }
}

public class TransportService
{
    public static ITransport Create(string type)
    {
        switch (type)
        {
            case "Air":
                {
                    var factory = new AirFactory();
                    return factory.CreateInstance();
                }
            case "Train":
                {
                    var factory = new TrainFactory();
                    return factory.CreateInstance();
                }

            case "Truck":
                {
                    return new TruckAdapter();
                }
            default:
                throw new NotImplementedException();
        }
    }
}

public interface ITransport
{
    void Send();
}

public class Air : ITransport
{
    public void Send()
    {
        Console.WriteLine("Send package by air ...");
    }
}

public class Train : ITransport
{
    public void Send()
    {
        Console.WriteLine("Send package by Train ...");
    }
}

public class TruckAdapter : ITransport
{
    private readonly Truck _truck;

    public TruckAdapter()
    {
        _truck = new Truck(5,"THR");
    }

    public void Send()
    {
        // Delegate the call to the Truck class's Deliver method
        // string -> xml nodes
        // <xml>
        // <node>............</node>
        //</xml>
        _truck.Deliver();
    }
}

public interface ITransportFactory
{
    ITransport CreateInstance();
}

public class AirFactory : ITransportFactory
{
    public ITransport CreateInstance()
    {
        //manage instance
        return new Air();
    }
}

public class TrainFactory : ITransportFactory
{
    public ITransport CreateInstance()
    {
        //manage instance
        return new Train();
    }
}

#endregion