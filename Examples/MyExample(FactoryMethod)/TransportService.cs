
namespace Examples.MyExample_FactoryMethod_
{
    public interface ITransport
    {
        void Book();
    }

    public class AirTransportationService : ITransport
    {
        private static AirTransportationService _airTransportationService;
        private static readonly object _lock = new();

        private AirTransportationService() { }

        public static AirTransportationService GetInstance()
        {
            lock (_lock)
            {
                if (_airTransportationService == null)
                    _airTransportationService = new AirTransportationService();
            }
            return _airTransportationService;
        }

        public void Book()
        {
            Console.WriteLine("Booking via AirTransport.");
        }
    }
    public class ShipTransportationService : ITransport
    {
        private readonly string _startLocation;
        private readonly string _endLocation;

        public ShipTransportationService(string startLocation, string endLocation)
        {
            _startLocation = startLocation;
            _endLocation = endLocation;
        }

        public void Book()
        {
            Console.WriteLine($"Booking via ShipTransport from {_startLocation} to {_endLocation}.");
        }
    }
    public class TrainTransportationService : ITransport
    {
        public TrainTransportationService()
        {
            Initialize();
        }

        private void Initialize()
        {
            Console.WriteLine("TrainTransport initialized.");
        }

        public void Book()
        {
            Console.WriteLine("Booking via TrainTransport.");
        }
    }

    public interface ITransportFactory
    {
        ITransport CreateTransport();
    }

    public class AirTransportationServiceFactory : ITransportFactory
    {
        public ITransport CreateTransport()
        {
            return AirTransportationService.GetInstance();
        }
    }

    public class ShipTransportationServiceFactory : ITransportFactory
    {
        private readonly string _startLocation;
        private readonly string _endLocation;

        public ShipTransportationServiceFactory(string startLocation, string endLocation)
        {
            _startLocation = startLocation;
            _endLocation = endLocation;
        }

        public ITransport CreateTransport()
        {
            return new ShipTransportationService(_startLocation, _endLocation);
        }
    }

    public class TrainTransportationServiceFactory : ITransportFactory
    {
        public ITransport CreateTransport()
        {
            return new TrainTransportationService();
        }
    }
}
