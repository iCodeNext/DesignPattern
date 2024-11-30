using Factory.Cargo.Factory;
using Factory.Cargo.Transportation;

namespace Factory.Cargo;

public class LibraryUser
{
    private readonly CargoFactoryApi _factoryApi = new CargoFactoryApi();

    public LibraryUser()
    {
        _factoryApi.AddBaseFactories();
        _factoryApi.AddTransportationFactory("Truck",new TruckTransportationFactory());

        var truckTransportation = _factoryApi.Create("Truck");
        
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
        => new AirTransportation();

    public ITransportation Create(string origin, string destination)
    {
        throw new NotImplementedException();
    }
}