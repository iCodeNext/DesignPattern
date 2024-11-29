namespace Examples.Cargo;

public class Ship : IBook
{
    private string _Origin;
    private string _Destination;
    public Ship(string Origin, string Destination)
    {
        _Origin = Origin;
        _Destination = Destination;
    }
    public void Book() => Console.WriteLine($"Booked from origin: {_Origin} to destination: {_Destination}");
}