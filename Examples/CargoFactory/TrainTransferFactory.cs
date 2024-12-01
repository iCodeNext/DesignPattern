namespace Examples.Cargo
{
    public class TrainTransferFactory : ITransferFactory
    {
        public ITransfer Send()
        {
            var train = new TrainTransfer();
            train.Initial();
            return train;
        }
    }
}
