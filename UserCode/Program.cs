

using Examples.FactoryPattern.CargoTransport;
using Examples.FactoryPattern.CargoTransport.Contract;

public class Program
{
    static void Main(string[] args)
    {
        //when very complex factory pattern

        TransportService factory = new TransportService();

        factory.Addvehicle(new Truck(),new TruckTransport());
        var vehicleTruck = factory.Create(typeof(Truck).Name, "", "");
        vehicleTruck.Delivery();

        var vehicleAir = factory.Create(typeof(Air).Name, "", "");
        vehicleAir.Delivery();


        var vehicleShip = factory.Create(typeof(Ship).Name, "Tehran", "Germany");
        vehicleShip.Delivery();


        var vehicleTrain = factory.Create(typeof(Train).Name, "", "");
        vehicleTrain.Delivery();


        //when complex factory pattern
        //var origin = "Tehran";
        //var destination = "Germany";

        //TransportService factory = new();

        //var instanceAir = factory.Create("Air", "", "");
        //instanceAir.Delivery();

        //var instanceShip = factory.Create("Ship", origin, destination);
        //instanceShip.Delivery();

        //var instanceTrain = factory.Create("Train", "", "");
        //instanceTrain.Delivery();



        Console.ReadKey();
    }
}