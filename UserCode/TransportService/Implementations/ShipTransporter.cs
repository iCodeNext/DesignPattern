namespace UserCode.TransportService.Contract;

public class ShipTransporter : ICargoTransportService
{
    private readonly string _from;
    private readonly string _to;

    public ShipTransporter(string from, string to)
    {
        _from = from;
        _to = to;
    }

    public void Book(string parcel)
    {
        Console.WriteLine($"Booking via Ship from {_from} to {_to}: {parcel}");
    }
}
