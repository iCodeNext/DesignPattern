using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examples.FactoryPattern.CargoTransport.Interface;

namespace Examples.FactoryPattern.CargoTransport.Impliment
{
    public class ShipTransport : Transport
    {
        private readonly string _origin;
        private readonly string _destination;

        public ShipTransport(string origin, string destination)
        {
            _origin = origin;
            _destination = destination;
        }
        public override void Delivery()
        {
            Console.WriteLine($"Transport Ship Delivery from {_origin} to {_destination}");
        }
    }
    public class ShipTransportFactory : TransportFactory
    {
        ShipTransport airInstance;
        public override ShipTransport CreateTransport()
        {
            airInstance = new ShipTransport(string.Empty, string.Empty);
            return airInstance;
        }
        public ShipTransport CreateTransport(string origin , string destination)
        {
            airInstance = new ShipTransport(origin, destination);
            return airInstance;
        }
    }
}
