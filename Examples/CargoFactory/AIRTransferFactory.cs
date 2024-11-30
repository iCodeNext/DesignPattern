namespace Examples.Cargo
{
    public class AIRTransferFactory : ITransferFactory
    {
        public ITransfer Send()
        {
            return new AIRTransfer();
        }

        public ITransfer Send(string origin, string destination)
        {
            throw new NotImplementedException();
        }
    }
}
