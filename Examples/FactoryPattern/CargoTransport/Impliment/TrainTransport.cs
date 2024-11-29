using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examples.FactoryPattern.CargoTransport.Interface;

namespace Examples.FactoryPattern.CargoTransport.Impliment
{
    public class TrainTransport : Transport
    {
        public override void Delivery()
        {
            Console.WriteLine("Transport Train Delivery");
        }
    }

    public class TrainTransportFactory : TransportFactory
    {
        private bool _isInitialized = false;
        TrainTransport airInstance;
        public TrainTransportFactory()
        {
            Initialize();
        }

        private void Initialize()
        {
            _isInitialized = true;
            Console.WriteLine("Train Transport initialize");
        }
        public override TrainTransport CreateTransport()
        {
            if (!_isInitialized)
            {
                throw new InvalidOperationException("Train Transport is not initialized.");
            }
            airInstance = new TrainTransport();
            return airInstance;
        }
    }
}
