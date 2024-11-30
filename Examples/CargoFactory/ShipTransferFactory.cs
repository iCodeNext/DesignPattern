namespace Examples.Cargo
{
    public class ShipTransferFactory : ITransferFactory
    {
        public ITransfer Send(string origin, string destination)
        {
            return new ShipTransfer(origin, destination);
        }

        public ITransfer Send()
        {
            throw new NotImplementedException();
        }
    }
}
