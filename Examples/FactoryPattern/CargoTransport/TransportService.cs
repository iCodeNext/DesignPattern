using Examples.FactoryPattern.CargoTransport.Contract;
using Examples.FactoryPattern.CargoTransport.Impliment;
using Examples.FactoryPattern.CargoTransport.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Examples.FactoryPattern.CargoTransport
{
    public class TransportService
    {
        //**when very complex factory method
        private Dictionary<string, Transport> transports = new Dictionary<string, Transport>();

        public TransportService()
        {
            AddDefultVehicle();
        }

        public void Addvehicle(IVehicle vehicle, Transport transport)
        {
            transports.Add(vehicle.GetType().Name, transport);
        }

        private void AddDefultVehicle()
        {
            transports.Add(typeof(Air).Name, new AirTransport());
            transports.Add(typeof(Ship).Name, new ShipTransport("",""));
            transports.Add(typeof(Train).Name,new  TrainTransport());
        }

        public Transport Create(string type , string? origin , string? destination)
        {
            if (transports.TryGetValue(type, out Transport transport))
            {
                return transport;
            }
            else
                throw new ArgumentNullException("Invalid Transport Type");
        }


        ///****************************************
        //when use complex factory method
        //private readonly TransportFactory transportFactory;

        //public Transport Create(string type ,string? orign ,string? destincation )
        //{
        //    if (type == "Air")
        //    {
        //        return new AirTransportFactory().CreateTransport(); 
        //    }
        //    else if (type == "Ship")
        //    {
        //        return new ShipTransportFactory().CreateTransport(orign, destincation);
        //    }
        //    else if (type == "Train")
        //    {
        //        return new TrainTransportFactory().CreateTransport();
        //    }
        //    else
        //        throw new ArgumentNullException("Invalid Transport Type");
        //    //return transportFactory.CreateTransport();
        //}

        // public Transport Create(string type)
        //{
        //    //if (type == "Air")
        //    //{
        //    //    return new AirTransport();
        //    //}
        //    //else if (type == "Ship")
        //    //{
        //    //    return new ShipTransport();
        //    //}
        //    //else if (type == "Train")
        //    //{
        //    //    return new TrainTransport();
        //    //}
        //    //else
        //    //    throw new ArgumentNullException("Invalid Transport Type");

        //} 


    }
}
