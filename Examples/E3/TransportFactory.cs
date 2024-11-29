namespace Examples.E3;

public abstract class TransportFactory
{
    public abstract ITransport CreateTransport();
}
public class AIRTransportFactory : TransportFactory
{
    private static Air? instance;
    public override ITransport CreateTransport()
    {
        if (instance == null)
        {
            instance = new();
        }
        return instance;
    }
}
public class ShipTransportFactory : TransportFactory
{
    private List<Ship> shipInstances = [];
    public override ITransport CreateTransport()
    {
        
        if(shipInstances.Count > 2)
            shipInstances.Clear();

        Ship transport = new();
        shipInstances.Add(transport);
        
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
