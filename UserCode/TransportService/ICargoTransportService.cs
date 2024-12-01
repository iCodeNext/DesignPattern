namespace UserCode.TransportService.Contract;

public interface ICargoTransportService
{
    void Book(string parcel);
}

public class CargoTransportFactory
{
    public static ICargoTransportService CreateTransport(TransportType transporterType)
    {
        return transporterType switch
        {
            TransportType.Air => AirTransporter.Instance,
            TransportType.Ship => new ShipTransporter("from", "to"),
            TransportType.Train => new TrainTransporter(),
            _ => throw new NotImplementedException(),
        };
    }
}