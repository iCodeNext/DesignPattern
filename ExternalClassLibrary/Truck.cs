namespace ExternalClassLibrary;

// External library class (inaccessible for modification)
public class Truck(int price, string from)
{
    public void Deliver()
    {
        Console.WriteLine("Deliver package by truck ...");
    }
}