

using Examples.FactoryPattern.CargoTransport;

public class Program
{
    static void Main(string[] args)
    {
        var origin = "Tehran";
        var destination = "Germany";

        TransportService factory = new();

        var instanceAir = factory.Create("Air", "", "");
        instanceAir.Delivery();

        var instanceShip = factory.Create("Ship", origin, destination);
        instanceShip.Delivery();

        var instanceTrain = factory.Create("Train", "", "");
        instanceTrain.Delivery();

        Console.ReadKey();
    }
}