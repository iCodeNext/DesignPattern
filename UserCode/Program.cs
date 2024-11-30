using static UserCode.CargoService;

namespace UserCode;

class Program
{
    static void Main(string[] args)
    {
        var factory = new TransportFactory();

        // Air Transport
        var airTransport = factory.CreateAirTransport();
        airTransport.Book();

        // Ship Transport
        var shipTransport = factory.CreateShipTransport("New York", "London");
        shipTransport.Book();

        // Train Transport
        var trainTransport = factory.CreateTrainTransport();
        trainTransport.Book();
    }
}
