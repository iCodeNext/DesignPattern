namespace Examples.Cargo;

public class Train : IShipping
{
    private bool _isInitialized = false;
    public void initialized()
    {
        _isInitialized = true;
        Console.WriteLine("Train initialized");
    }

    public void PrintDetail()
    {
        if (!_isInitialized)
        {
            throw new ArgumentException("Train is not initialized");
        }
        Console.WriteLine("Cargo by Train");
    }
}