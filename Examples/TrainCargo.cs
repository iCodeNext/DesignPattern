public class TrainCargo : ICargo
{
    public TrainCargo()
    {
        Initialize();
    }

    public void Initialize()
    {
        Console.WriteLine("Train Cargo Initialization");
    }

    public void Send()
    {
        Console.WriteLine("Sending by Train");
    }
}

