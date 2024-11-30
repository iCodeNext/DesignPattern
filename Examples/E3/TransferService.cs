using System;

public enum CargoType
{
    Air,
    Ship,
    Train
}

public interface ICargo
{
    void Book();
}

public class AirCargo : ICargo
{
    private static AirCargo? _instance;
    private static readonly object LockObject = new();

    private AirCargo()
    {
    }

    public static AirCargo GetInstance()
    {
        if (_instance == null)
        {
            lock (LockObject)
            {
                _instance ??= new AirCargo();
            }
        }

        return _instance;
    }

    public void Book()
    {
        Console.WriteLine("Air Cargo has been booked.");
    }
}

public class ShipCargo(string? origin, string destination) : ICargo
{
    public void Book()
    {
        Console.WriteLine($"Ship Cargo booked from {origin} to {destination}.");
    }
}

public class TrainCargo : ICargo
{
    public TrainCargo()
    {
        Initialize();
    }

    private void Initialize()
    {
        Console.WriteLine("Train Cargo initialized.");
    }

    public void Book()
    {
        Console.WriteLine("Train Cargo has been booked.");
    }
}

public class CargoService
{
    public static ICargo GetCargo(CargoType cargoType, string? origin = null, string? destination = null)
    {
        switch (cargoType)
        {
            case CargoType.Air:
                return AirCargo.GetInstance();
            case CargoType.Ship:
                if (string.IsNullOrWhiteSpace(origin) || string.IsNullOrWhiteSpace(destination))
                {
                    throw new ArgumentException("Origin and destination must be provided for Ship Cargo.");
                }

                return new ShipCargo(origin, destination);
            case CargoType.Train:
                return new TrainCargo();
            default:
                throw new NotSupportedException("Unsupported cargo type.");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var airCargo = CargoService.GetCargo(CargoType.Air);
        airCargo.Book();

        var shipCargo = CargoService.GetCargo(CargoType.Ship, "Iran", "Turkey");
        shipCargo.Book();

        var trainCargo = CargoService.GetCargo(CargoType.Train);
        trainCargo.Book();
    }
}
