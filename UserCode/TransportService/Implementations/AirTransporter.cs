namespace UserCode.TransportService.Contract;

public class AirTransporter : ICargoTransportService
{
    private static AirTransporter _instance;
    private AirTransporter(){}

    public static AirTransporter Instance
    {
        get
        {
            if (_instance == null)
                _instance = new AirTransporter();
            return _instance;
        }
    }

    public void Book(string parcel)
    {
        Console.WriteLine($"Booking package via Air: {parcel}");
    }
}
