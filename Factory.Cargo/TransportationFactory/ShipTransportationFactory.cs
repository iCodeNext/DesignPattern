using Factory.Cargo.Factory;
using Factory.Cargo.Transportation;

namespace Factory.Cargo.TransportationFactory;

public class ShipTransportationFactory : ITransportationFactory
{

    public ITransportation Create() 
        => throw new NotImplementedException("Ship transportation should be initialized with origin and destination");

    public ITransportation Create(string origin, string destination)
        => new ShipTransportation(origin, destination);
}