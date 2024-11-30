using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.E3
{


    public class Program
    {
        public void Main()
        {

            // ارسال با هواپیما
            ITransport airTransport = CargoFactory.CreateTransport("air");
            airTransport.SendPackage();

            // ارسال با کشتی
            ITransport shipTransport = CargoFactory.CreateTransport("ship", "gheshm", "kish");
            shipTransport.SendPackage();

            // ارسال با قطار
            ITransport trainTransport = CargoFactory.CreateTransport("train");
            trainTransport.SendPackage();
        }
    }



    public class CargoFactory
    {
        public static ITransport CreateTransport(string transportType, string origin = "", string destination = "")
        {
            switch (transportType.ToLower())
            {
                case "air":
                    return new AirFactoryTransport().CreateTransport();

                case "ship":
                    return new ShipFactoryTransport(origin, destination).CreateTransport();

                case "train":
                    return new TrainFactoryTransport().CreateTransport();

                default:
                    throw new ArgumentException("Invalid transport type");
            }
        }
    }


    public interface ITransport
    {
        void SendPackage();
    }



    public class ShipTransport : ITransport
    {
        private string _origin;
        private string _destination;

        public ShipTransport(string origin, string destination)
        {
            _origin = origin;
            _destination = destination;
        }

        public void SendPackage()
        {
            Console.WriteLine($"Send Package with ship from {_origin} to {_destination} ");
        }
    }


    public class AirTransport : ITransport
    {
        public void SendPackage()
        {
            Console.WriteLine($"Send Package with Air");
        }
    }



    public class TrainTransport : ITransport
    {
        public void Initialize()
        {
            Console.WriteLine("Initializing train transport system...");
        }

        public void SendPackage()
        {
            Console.WriteLine($"Send Package with Air Train");
        }
    }




    public interface ITransportFactory
    {
        ITransport CreateTransport();
    }



    public class ShipFactoryTransport : ITransportFactory
    {
        private string _origin;
        private string _destination;

        public ShipFactoryTransport(string origin, string destination)
        {
            _origin = origin;
            _destination = destination;
        }

        public ITransport CreateTransport()
        {
            return new ShipTransport(_origin, _destination);
        }
    }


    public class AirFactoryTransport : ITransportFactory
    {
        private static AirTransport _airInstance;


        public ITransport CreateTransport()
        {
            if (_airInstance == null)
            {
                _airInstance = new AirTransport();
            }
            return _airInstance;
        }




    }



    public class TrainFactoryTransport : ITransportFactory
    {
        public ITransport CreateTransport()
        {
            var trainPack = new TrainTransport();
            trainPack.Initialize();
            return trainPack;
        }
    }
}
