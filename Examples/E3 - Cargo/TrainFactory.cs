namespace Examples.Cargo;

public class TrainFactory : ITransportFactory
{
    public ITransport CreateTransport()
    {
        return new Train();
    }
}

