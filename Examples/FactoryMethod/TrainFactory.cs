namespace Examples.Cargo
{
    public class TrainFactory : TransportFactory
    {
        public override ITransport Transfer()
        {
            var train = new Train();
            Initialize();
            return train;
        }
        void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}
