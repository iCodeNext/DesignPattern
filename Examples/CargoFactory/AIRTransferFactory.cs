namespace Examples.Cargo
{
    public class AIRTransferFactory : ITransferFactory
    {
        private readonly AIRTransfer _instance;
        public ITransfer Send()
        {
            return _instance ?? new AIRTransfer();
        }
    }
}
