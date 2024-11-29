namespace CargoTransportService;

public class TrainTransport : CargoTransport
{
	public TrainTransport()
	{
		Initialize();
	}

	private static void Initialize()
	{
		Console.WriteLine("Train transport initialized.");
	}

	public override void Book()
	{
		Console.WriteLine("Package booked via Train Transport.");
	}
}