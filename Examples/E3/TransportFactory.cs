namespace Examples.E3;

public abstract class TransportFactory
{
    public abstract ITransport CreateTransport();
}
public class AIRTransportFactory : TransportFactory
{
    Air transport;
    public override ITransport CreateTransport()
    {
        transport = new();

        return transport;
    }
}
public class ShipTransportFactory : TransportFactory
{
    List<Ship> shipInstaces = [];
    public override ITransport CreateTransport()
    {
        Ship transport = new();

        if(shipInstaces.Count > 2)
            shipInstaces.Clear();

        shipInstaces.Add(transport);
        
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
