namespace Examples.E3;

public abstract class TransportFactory
{
    public abstract ITransport CreateTransport();
}
public class AIRTransportFactory : TransportFactory
{
    private static Air? _instance;
    public override ITransport CreateTransport()
    {
        if (_instance == null)
        {
            _instance = new();
        }
        return _instance;
    }
}
public class ShipTransportFactory : TransportFactory
{
    private List<Ship> _shipInstances = [];
    public override ITransport CreateTransport()
    {
        
        if(_shipInstances.Count > 2)
            _shipInstances.Clear();

        Ship transport = new();
        _shipInstances.Add(transport);
        
        return transport;
    }
}
public class TrainTransportFactory : TransportFactory
{
    public override ITransport CreateTransport()
    {
        Train transport = new();
        transport.Init();

        return transport;
    }
}
