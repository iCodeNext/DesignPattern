namespace Examples.Cargo  //
{
    public class TrainFactory : TransportFactory
    {
        public override ITransport Transfer()
        {
            var train = new Train();
            CallTrain();
            return train;
        }
        void CallTrain()
        {
            throw new NotImplementedException();
        }
    }
}
