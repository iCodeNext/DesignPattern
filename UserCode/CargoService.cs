namespace UserCode
{
    public class CargoService
    {

        public class TransportFactory
        {
            public Transport CreateAirTransport()
            {
                return AirTransport.GetInstance();
            }

            public Transport CreateShipTransport(string origin, string destination)
            {
                return new ShipTransport(origin, destination);
            }

            public Transport CreateTrainTransport()
            {
                return new TrainTransport();
            }
        }

        public abstract class Transport
        {
            public abstract void Book();
        }

        public class AirTransport : Transport
        {
            private static AirTransport _instance;

            private AirTransport() { }

            public static AirTransport GetInstance()
            {
                if (_instance == null)
                {
                    _instance = new AirTransport();
                }
                return _instance;
            }

            public override void Book()
            {
                Console.WriteLine("Booking via Air Transport.");
            }
        }

        public class ShipTransport : Transport
        {

            private readonly string _origin;
            private readonly string _destination;

            public ShipTransport(string origin, string destination)
            {
                _origin = origin;
                _destination = destination;
            }

            public override void Book()
            {
                Console.WriteLine($"Booking via Ship from {_origin} to {_destination}.");
            }
        }

        public class TrainTransport : Transport
        {
            private bool _initialized = false;

            public TrainTransport()
            {
                Initialize(); 
            }

            private void Initialize()
            {
                _initialized = true;
                Console.WriteLine("Train Transport Initialized.");
            }

            public override void Book()
            {
                if (!_initialized)
                {
                    throw new InvalidOperationException("Train must be initialized before booking.");
                }
                Console.WriteLine("Booking via Train Transport.");
            }
        }
    }
}
