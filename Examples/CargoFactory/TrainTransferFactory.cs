namespace Examples.Cargo
{
    public class TrainTransferFactory : ITransferFactory
    {
        public ITransfer Send()
        {
            throw new Exception("");
        }

        public ITransfer Send(string origin, string destination)
        {
            var train = new TrainTransfer();
            train.Initial();
            return train;
        }
    }
}
