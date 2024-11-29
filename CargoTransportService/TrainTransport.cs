namespace CargoTransportService;

public class TrainTransport : CargoTransport
{
	public TrainTransport()
	{
		Initialize();
	}

	public override void Book()
	{
		Console.WriteLine("Package booked via Train Transport.");
	}

	private void Initialize()
	{
		Console.WriteLine("Train transport initialized.");
	}
}