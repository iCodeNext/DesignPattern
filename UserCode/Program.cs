using Examples.E3;

namespace UserCode;


public class Program()
{
    public static void Main()
    {
        Console.WriteLine("Create Transport Factory");
  
        TransportFactory shipFactory = new ShipTransportFactory();
        TransportService transportService = new(shipFactory);
        var ship1 = transportService.Create();
        //ship1.Delivery();

        var ship2 = transportService.Create();
        //ship2.Delivery();

        TransportFactory airFactory = new AIRTransportFactory();
        transportService = new(airFactory);
        var air = transportService.Create();
        //air.Delivery();


        TransportFactory trainFactory = new TrainTransportFactory();
        transportService = new(trainFactory);
        var train = transportService.Create();
        //train.Delivery();
        

        Console.WriteLine("Instances created successfully.");
    }
}
