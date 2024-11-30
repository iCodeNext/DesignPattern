public class ShipCargo : ICargo
{
    private string origin;
    private string destination;

    public ShipCargo(string origin, string destination)
    {
        this.origin = origin;
        this.destination = destination;
    }

    public void Send()
    {
        Console.WriteLine($"Sending by Ship from {origin} to {destination}");
    }
}

