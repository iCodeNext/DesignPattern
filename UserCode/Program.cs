using Examples.E3;

namespace UserCode;


public class Program()
{
    public static void Main()
    {
        Console.WriteLine("Create Transport Factory");

        TransportService service = new ();

        var instanse = service.Create("Ship");
    }
}
