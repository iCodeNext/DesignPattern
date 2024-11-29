using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examples.FactoryPattern.CargoTransport.Interface;

namespace Examples.FactoryPattern.CargoTransport.Impliment
{
    public class AirTransport : Transport
    {
        public override void Delivery()
        {
            Console.WriteLine("Transport Air Delivery");
        }
    }

    public class AirTransportFactory : TransportFactory
    {
        AirTransport airInstance;   
        public override Transport CreateTransport()
        {
            airInstance = new AirTransport();
            return airInstance;
        }
    }
}
