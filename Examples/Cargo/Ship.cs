namespace Examples.Cargo;

public class Ship : IShipping
{
    private string _Origin;
    private string _Destination;
    public Ship(string Origin, string Destination)
    {
        _Origin = Origin;
        _Destination = Destination;
    }
    public void Create() => Console.WriteLine($"Booked from origin: {_Origin} to destination: {_Destination}");

    public void PrintDetail()
    {
        Console.WriteLine($"Cargo by Ship from {_Origin} to {_Destination}");
    }
}