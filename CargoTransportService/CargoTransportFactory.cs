namespace CargoTransportService;

public class CargoTransportFactory
{
	public static CargoTransport CreateTransport(string type, string source = null, string destination = null)
	{
		return type switch
		{
			"AIR" => AirTransport.GetInstance(),
			"SHIP" => new ShipTransport(source, destination),
			"TRAIN" => new TrainTransport(),
			_ => throw new ArgumentException("Invalid transport type."),
		};
	}
}