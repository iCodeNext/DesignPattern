namespace Examples.E1;

public class CargoService
{
    public ICargo BookProduct(byte type, string? origin = null, string? destination = null)
    {
        CargoFactory? factory = null;
        if (type == (byte)CargoType.Air)
        {
            factory = new AirFactory();
        }
        if (type == (byte)CargoType.Ship)
        {
            if (string.IsNullOrWhiteSpace(origin))
                throw new ArgumentException("Origin should not be null or empty.", nameof(origin));

            if (string.IsNullOrWhiteSpace(destination))
                throw new ArgumentException("Destination should not be null or empty.", nameof(destination));
            factory = new ShipFactory(origin, destination);

        }
        if (type == (byte)CargoType.Air)
        {
            factory = new TrainFactory();

        }
        if (factory is null)
            throw new Exception("cargotype is wrong please enter a new type");
        return factory.Create(origin, destination);
    }
}

public abstract class CargoFactory
{
    public abstract ICargo Create(string? origin = null, string? destination = null);
}

public class TrainFactory : CargoFactory
{
    public override ICargo Create(string? origin = null, string? destination = null)
    {
        var cargo = new Train();
        TrainMethod();
        return cargo;
    }

    private void TrainMethod() => Console.WriteLine("train is new");
}

public class ShipFactory : CargoFactory
{
    public ShipFactory(string origin, string destination)
    {
        Origin = origin;
        Destination = destination;
    }

    public string Origin { get; set; }
    public string Destination { get; set; }
    public override ICargo Create(string? origin, string? destination)
    {
        return new Ship(origin, destination);
    }
}

public class AirFactory : CargoFactory
{
    private static readonly Lazy<Air> _air = new Lazy<Air>(() => new Air());

    public override ICargo Create(string? origin, string? destination)
    {
        return _air.Value;
    }
}

public class Train : ICargo
{
    public decimal SetPayment()
    {
        return 500;
    }
}

public class Ship : ICargo
{
    public Ship(string origin, string destination)
    {
        Origin = origin;
        Destination = destination;
    }

    public string Origin { get; set; }
    public string Destination { get; set; }
    public decimal SetPayment()
    {
        return 2000;
    }
}

public class Air : ICargo
{
    public decimal SetPayment() 
    {
        return 1000;
    }
}

public interface ICargo
{
    public decimal SetPayment();
}
public enum CargoType
{
    NotSet = 0,
    Air = 1,
    Ship = 2,
    Train = 3,
}

