
namespace Examples.Cargo
{
    public class ShipFactory : TransportFactory
    {
        private readonly string _origin;
        private readonly string _destination;

        public ShipFactory(string origin, string destination)
        {
            _origin = origin;
            _destination = destination;
        }

        public override ITransport Transfer()
        {
            return new Ship(_origin, _destination);
        }
    }
}
