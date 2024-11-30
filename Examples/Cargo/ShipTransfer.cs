namespace Examples.Cargo
{
    public class ShipTransfer : ITransfer
    {
        private readonly string _origin;
        private readonly string _destination;
        public ShipTransfer(string origin, string destination)
        {
            _origin = origin;
            _destination = destination;
        }
        public void Send()
        {

        }
    }
}
