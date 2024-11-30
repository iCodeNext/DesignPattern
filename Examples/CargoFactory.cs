public class CargoFactory
{
    public static ICargo CreateCargo(string type, string origin = null, string destination = null)
    {
        switch (type.ToLower())
        {
            case "air":
                return AirCargo.GetInstance();
            case "ship":
                return new ShipCargo(origin, destination);
            case "train":
                return new TrainCargo();
            default:
                throw new ArgumentException("Invalid cargo type");
        }
    }
}

