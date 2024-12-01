using Examples.Cargo;

namespace Examples.ExtendedCargo
{
    public class TruckFactory : ITransportFactory
    {
        public ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
