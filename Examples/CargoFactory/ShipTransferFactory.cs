namespace Examples.Cargo
{
    public class ShipTransferFactory : ITransferFactory
    {
        private readonly string _origin;
        private readonly string _destination;
        public ShipTransferFactory(string origin, string destination)
        {
            _origin = origin;
            _destination = destination;
        }
        public ITransfer Send()
        {
            return new ShipTransfer(_origin, _destination);
        }
    }
}
