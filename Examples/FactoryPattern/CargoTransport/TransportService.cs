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
        private readonly TransportFactory transportFactory;

        public Transport Create(string type ,string? orign ,string? destincation )
        {
            if (type == "Air")
            {
                return new AirTransportFactory().CreateTransport(); 
            }
            else if (type == "Ship")
            {
                return new ShipTransportFactory().CreateTransport(orign, destincation);
            }
            else if (type == "Train")
            {
                return new TrainTransportFactory().CreateTransport();
            }
            else
                throw new ArgumentNullException("Invalid Transport Type");
            //return transportFactory.CreateTransport();
        }

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
