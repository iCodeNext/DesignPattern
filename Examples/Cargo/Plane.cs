namespace Examples.Cargo;

public class AirCargo : IBook
{
    private static AirCargo _instance;
    private AirCargo() { }
    public static AirCargo Instance => _instance ??= new AirCargo();
    public void Book()
    {
        Console.WriteLine("AirCargo booked.");
    }
}