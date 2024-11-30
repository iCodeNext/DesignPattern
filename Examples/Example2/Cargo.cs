using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Example2
{
    using System;
    using Examples.Example2.Factory;
    using Examples.Example2.Intrface;

    namespace CargoSystem
    {
        public class CargoSystem
        {
            public static void Main(string[] args)
            {
                TransportFactory airFactory = new AirFactory();
                ITransport airTransport = airFactory.CreateTransport();
                airTransport.Book("Electronics");

                TransportFactory shipFactory = new ShipFactory("Port A", "Port B");
                ITransport shipTransport = shipFactory.CreateTransport();
                shipTransport.Book("Furniture");

                TransportFactory trainFactory = new TrainFactory();
                ITransport trainTransport = trainFactory.CreateTransport();
                trainTransport.Book("Coal");
            }
        }
    }

}
