public class AirCargo : ICargo
{
    private static AirCargo instance;
    private AirCargo() { }

    public static AirCargo GetInstance()
    {
        if (instance == null)
        {
            instance = new AirCargo();
        }
        return instance;
    }

    public void Send()
    {
        Console.WriteLine("Sending by Air");
    }
}

