using Examples.FactoryPattern.CargoTransport.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.FactoryPattern.CargoTransport.Contract
{
    public class TruckTransport : Transport
    {
        public override void Delivery()
        {
            Console.WriteLine($"Transport Truck Delivery");
        }
    }
    //public class TruckTransportFactory : TransportFactory
    //{
    //    TruckTransport TruckInstance;
    //    public override Transport CreateTransport()
    //    {
    //        TruckInstance = new TruckTransport();
    //        return TruckInstance;
    //    }
    //}


}
