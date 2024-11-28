namespace Examples.Cargo;

public class Train : IBook
{
    private bool _isInitialized = false;
    public void initialized()
    {
        _isInitialized = true;
        Console.WriteLine("Train initialized");
    }

    public void Book()
    {
        if (!_isInitialized)
        {
            throw new Exception("Book not ready");
        }
        Console.WriteLine("Train Booked");
    }
}