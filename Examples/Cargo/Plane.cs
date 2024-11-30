namespace Examples.Cargo;

public class AirCargo : IShipping
{
    private static AirCargo _instance;

    private AirCargo()
    {
    }

    public static AirCargo Instance => _instance ??= new AirCargo();

    public void PrintDetail() => Console.WriteLine("Cargo by Plane");
}