namespace UserCode.TransportService.Contract;

public class TrainTransporter : ICargoTransportService
{
    private bool _isInitialized;
    public TrainTransporter()
    {
        _isInitialized = false;
    }

    public void Initialize()
    {
        _isInitialized = true;
        Console.WriteLine("initialized method at first call");
    }

    public void Book(string parcel)
    {
        if (!_isInitialized)
            throw new InvalidOperationException("You must be call initialized method before booking");

        Console.WriteLine($"Booking via Train: {parcel}");
    }
}
