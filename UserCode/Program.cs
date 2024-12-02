using Examples.E1;

namespace UserCode;
class Program
{
    static void Main()
    {
        var cargoService = new CargoService();
        Console.WriteLine("please enter cargo type ");
        Console.WriteLine($"air = " + CargoType.Air);
        Console.WriteLine($"ship = " + CargoType.Ship);
        Console.WriteLine($"train = " + CargoType.Train);
        byte type;
        Console.WriteLine("Please enter a number between 0 and 255:");
        while (!byte.TryParse(Console.ReadLine(), out type))
        {
            Console.WriteLine("Invalid input. Please enter a valid byte value (0-255):");
        }
        string? origin = null;
        string? destination = null;
        if (type == (byte)CargoType.Ship)
        {
            Console.Write("please enter origin ");
            origin = Console.ReadLine();
            Console.Write("please enter destination ");
            destination = Console.ReadLine();
        }


        cargoService.BookProduct(type, origin, destination);
    }
}