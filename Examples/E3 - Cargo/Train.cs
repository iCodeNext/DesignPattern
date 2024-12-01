
namespace Examples.Cargo;

public class Train : ITransport
{
    public Train() => Initialize();

    public void TransferPackage()
    {
        Console.WriteLine($"Package will be sent via Train.");
    }

    private void Initialize() => Console.WriteLine("Train transporation initialized.");
}
