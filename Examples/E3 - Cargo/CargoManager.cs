namespace Examples.Cargo;
public class CargoManager()
{
    public ITransport GetTransport(TransportType type, string origin = "", string destination = "")
    {
        return type switch
        {
            TransportType.Air => CreateAirTransport(),
            TransportType.Train => CreateTrainTransport(),
            TransportType.Ship => CreateShipTransport(origin, destination),
            _ => throw new ArgumentException($"Invalid Transport type: {type}.")
        };
    }
    private ITransport CreateAirTransport()
    {
        var airFactory = new AirFactory();
        return airFactory.CreateTransport();
    }

    private ITransport CreateTrainTransport()
    {
        var trainFactory = new TrainFactory();
        return trainFactory.CreateTransport();
    }

    private ITransport CreateShipTransport(string origin, string destination)
    {
        if (string.IsNullOrEmpty(origin) || string.IsNullOrEmpty(destination))
        {
            throw new ArgumentException("Both origin and destination must be provided for Ship transport.");
        }
        var shipFactory = new ShipFactory(origin, destination);
        return shipFactory.CreateTransport();
    }
}
