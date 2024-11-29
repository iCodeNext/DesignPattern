
namespace Examples.Cargo;

public class Air : ITransport
{
    private static readonly Lazy<Air> _instance = new(() => new Air());

    private Air() { }

    public static Air Instance => _instance.Value;

    public void TransferPackage()
    {
        Console.WriteLine($"Package will be sent via Airplane.");
    }
}
