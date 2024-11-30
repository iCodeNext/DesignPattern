using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examples.Example2.Intrface;
using Examples.Example2.Transport;

namespace Examples.Example2.Factory
{
    public class AirFactory : TransportFactory
    {
        public override ITransport CreateTransport()
        {
            return AirTransport.GetInstance();
        }
    }
}
