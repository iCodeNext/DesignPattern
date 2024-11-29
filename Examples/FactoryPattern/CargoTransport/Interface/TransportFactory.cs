using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.FactoryPattern.CargoTransport.Interface
{
    public abstract class TransportFactory
    {
        public abstract Transport CreateTransport();
    }
}
