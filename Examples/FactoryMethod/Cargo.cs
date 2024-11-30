namespace Examples.Cargo
{
    public class Cargo
    {
        public TransportFactory Transport(string type)
        {
            return type switch
            {
                "Train" => new TrainFactory(),
                "ship" => new ShipFactory("Tehran", "Shiraz"),
                "AirPlane" => AirPlaneFactory.GetFactory(),
                _ => throw new ArgumentException($"The Notification type{type} is Invalid"),
            };
        }
    }
}