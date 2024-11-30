using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examples.Example2.Intrface;

namespace Examples.Example2.Transport
{
    public class ShipTransport : ITransport
    {
        private readonly string source;
        private readonly string destination;

        public ShipTransport(string source, string destination)
        {

            this.source = source;
            this.destination = destination;
        }

        public void Book(string packageDetails)
        {
            Console.WriteLine($"Package booked via SHIP from {source} to {destination}: {packageDetails}");
        }
    }
}
