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
                "AirPlane" => new AirPlaneFactory(),
                _ => throw new ArgumentException($"The Notification type{type} is Invalid"),
            };
        }
    }
}
