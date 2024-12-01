namespace Examples.Cargo;

public class ShipFactory(string origin, string destination) : ITransportFactory
{
    public ITransport CreateTransport()
    {
        return new Ship(origin, destination);
    }
}
