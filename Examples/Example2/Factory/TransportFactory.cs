using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examples.Example2.Intrface;

namespace Examples.Example2.Factory
{
    public abstract class TransportFactory
    {
        public abstract ITransport CreateTransport();
    }
}
