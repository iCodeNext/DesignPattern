namespace Examples.Cargo
{
    public class AIRTransfer : ITransfer
    {
        private static AIRTransfer? _instance;
        public void Send()
        {
            _instance = _instance ?? new AIRTransfer();
        }
    }
}
