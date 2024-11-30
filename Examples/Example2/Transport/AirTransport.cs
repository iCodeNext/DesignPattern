using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examples.Example2.Intrface;

namespace Examples.Example2.Transport
{
    public class AirTransport : ITransport
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

        public void Book(string packageDetails)
        {
            Console.WriteLine($"Package booked via AIR: {packageDetails}");
        }
    }
}
