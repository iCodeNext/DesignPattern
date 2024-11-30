namespace Examples.Cargo;

public class Truck : IShipping
{
    private readonly string _truckNumber;

    public Truck(string TruckNumber)
    {
        _truckNumber = TruckNumber;
    }
    public void PrintDetail()
    {
        Console.WriteLine($"Cargo by Truck. TruckNumber: {_truckNumber}");
    }
}