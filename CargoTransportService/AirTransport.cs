namespace CargoTransportService;

public class AirTransport : CargoTransport
{
	private static AirTransport _instance;

	private AirTransport()
	{
	}

	public static AirTransport GetInstance()
	{
		if (_instance == null) 
		{
			_instance = new AirTransport(); 
		}
		return _instance; 
	}

	public override void Book()
	{
		Console.WriteLine("Package booked via Air Transport.");
	}
}