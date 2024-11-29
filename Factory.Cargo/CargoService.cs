using Factory.Cargo.Factory;
using Factory.Cargo.Transportation;

namespace Factory.Cargo;

public enum TransportationMode
{
    Air,
    Ship,
    Train
}

public class CargoService
{
    public ITransportation CreateTransportation(
        TransportationMode transportationMode,
        string? origin,
        string? destination)
    {
        return transportationMode switch
        {
            TransportationMode.Air => new AirTransportation(),
            TransportationMode.Ship => new ShipTransportation(origin, destination),
            TransportationMode.Train => new TrainTransportation(),
            _ => throw new NotImplementedException("Requested transport mode is not implemented.")
        };
    }
}