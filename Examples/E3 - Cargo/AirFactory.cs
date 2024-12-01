namespace Examples.Cargo;

public class AirFactory : ITransportFactory
{
    public ITransport CreateTransport()
    {
        return Air.Instance;
    }
}
