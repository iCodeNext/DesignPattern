
namespace Examples.E3
{
    public class program
    {

        public ITransport BookingService(string transportType,string startLocation,string endLocation)
        {
            if (transportType== "Air")
                return  new AirTransportFactory().CareteTransport();

            if (transportType== "Ship")
                return new ShipTransportFactory(startLocation,endLocation).CareteTransport();

            if (transportType== "Train")
                return new TrainTransportFactory().CareteTransport();

           throw new ArgumentException("invalid transportType");
         
        } 
    }

    public interface ITransport
    {
        void Book();
    }

    public class AirTransport : ITransport
    {

        public void Book()
        {
            Console.WriteLine("Booking via AirTransport.");
        }
    }

    public class TrainTransport : ITransport
    {
        public TrainTransport()
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

    public class ShipTransport(string startLocation,string endLocation) : ITransport
    {

        public void Book()
        {
            Console.WriteLine($"Booking via ShipTransport from {startLocation} to {endLocation}.");
        }
    }


    public interface ITransportFactory
    {
        ITransport CareteTransport();
    }
    public class AirTransportFactory : ITransportFactory
    {
        ITransport instance;

        public ITransport CareteTransport()
        {
            instance = new AirTransport();

            return instance;

        }
    }

    public class TrainTransportFactory : ITransportFactory
    {
        public ITransport CareteTransport()
        {
            return new TrainTransport();
        }
    }

    public class ShipTransportFactory(string startLocation,string endLocation) : ITransportFactory
    {
        public ITransport CareteTransport()
        {
            return new ShipTransport(startLocation,endLocation);
        }
    }


}
