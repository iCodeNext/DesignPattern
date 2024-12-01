using Factory.Cargo.Factory;
using Factory.Cargo.TransportationFactory;

namespace Factory.Cargo;

public class CargoFactoryService
{
    private Dictionary<string, ITransportationFactory> _transportationFactories = new();

    public void AddBaseFactories()
    {
        _transportationFactories.Add("Air",new AirTransportationFactory());
        _transportationFactories.Add("Train",new TrainTransportationFactory());
        _transportationFactories.Add("Ship",new ShipTransportationFactory());
    }
    
    
    public void AddTransportationFactory(string mode, ITransportationFactory transportationFactory)
        => _transportationFactories.Add(mode, transportationFactory);

    public ITransportation Create(string mode, string? origin = null, string? destination = null)
    {
        if (_transportationFactories.TryGetValue(mode, out var transportationFactory) || transportationFactory is null)
            throw new NotImplementedException($"The factory {mode} didn't define.");
        try
        {
            return transportationFactory.Create(origin, destination);
        }
        catch
        {
            Console.WriteLine($"The factory {transportationFactory.GetType()} not accepting args.");
        }

        return transportationFactory.Create();
    }
}