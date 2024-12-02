namespace Examples.MyExample_FactoryMethod_;

public class ProgramExample
{
    public static void RunApplication()
    {

        ITransportFactory airFactory = new AirTransportationServiceFactory();
        ITransport airTransport = airFactory.CreateTransport();
        airTransport.Book();


        ITransportFactory shipFactory = new ShipTransportationServiceFactory("StartLocation", "EndLocation");
        ITransport shipTransport = shipFactory.CreateTransport();
        shipTransport.Book();


        ITransportFactory trainFactory = new TrainTransportationServiceFactory();
        ITransport trainTransport = trainFactory.CreateTransport();
        trainTransport.Book();
    }
}
