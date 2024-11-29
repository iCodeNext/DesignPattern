namespace CargoTransportService;

public class Program
{
	private static void Main(string[] args)
	{
		try
		{
			var airTransport1 = CargoTransportFactory.CreateTransport("AIR");
			var airTransport2 = CargoTransportFactory.CreateTransport("AIR");
			airTransport1.Book();
			Console.WriteLine(ReferenceEquals(airTransport1, airTransport2)); // True


			var shipTransport = CargoTransportFactory.CreateTransport("SHIP", "New York", "London");
			shipTransport.Book();

			var trainTransport = CargoTransportFactory.CreateTransport("TRAIN");
			trainTransport.Book();
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Error: {ex.Message}");
		}
	}
}