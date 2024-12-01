using Factory.Cargo.Factory;
using Factory.Cargo.Transportation;

namespace Factory.Cargo;

public class LibraryUser
{
    private readonly CargoFactoryService _factoryService = new CargoFactoryService();

    public LibraryUser()
    {
        _factoryService.AddTransportationFactory("Truck",new TruckTransportationFactory());

        var truckTransportation = _factoryService.Create("Truck");
        
    }
}

public class TruckTransportation : ITransportation
{
    public void SendCargo()
    {
        Console.WriteLine("Sending cargo through truck.");
    }
}

public class TruckTransportationFactory : ITransportationFactory
{
    public ITransportation Create()
        => new TruckTransportation();

    public ITransportation Create(string origin, string destination)
    {
        throw new NotImplementedException();
    }
}