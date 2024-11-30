using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examples.Example2.Intrface;
using Examples.Example2.Transport;

namespace Examples.Example2.Factory
{
    public class ShipFactory : TransportFactory
    {
        private readonly string source;
        private readonly string destination;

        public ShipFactory(string source, string destination)
        {
            this.source = source;
            this.destination = destination;
        }

        public override ITransport CreateTransport()
        {
            return new ShipTransport(source, destination);
        }
    }
}
