namespace Examples.E3;

public class TransportService
{
    private readonly TransportFactory _transportFactory;

    public TransportService(TransportFactory transportFactory)
    {
        _transportFactory = transportFactory;
    }

    public ITransport Create()
    {
        return _transportFactory.CreateTransport();
    }
}
