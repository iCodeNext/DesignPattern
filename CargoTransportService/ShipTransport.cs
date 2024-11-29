namespace CargoTransportService;

public class ShipTransport(string source, string destination) : CargoTransport
{
	public override void Book()
	{
		Console.WriteLine($"Package booked via Ship Transport from {source} to {destination}.");
	}
}