
namespace Examples.Cargo;

public class Ship(string origin, string destination) : ITransport
{
    public void TransferPackage()
    {
        Console.WriteLine($"The Package will be sent via Ship from {origin} to {destination}.");
    }
}
