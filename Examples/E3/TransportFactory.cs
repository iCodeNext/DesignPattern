namespace Examples.E3
{
    public abstract class TransportFactory
    {
        public abstract Transport CreateTransport(string transportType);
    }
    public class AIRTransportFactory : TransportFactory
    {
        AIR transport;
        public override Transport CreateTransport(string transportType)
        {
            transport = new AIR();

            return transport;
        }
    }
    public class ShipTransportFactory : TransportFactory
    {
        List<Ship> shipInstaces = new List<Ship>();
        public override Transport CreateTransport(string transportType)
        {
            Ship transport = new Ship();

            if(shipInstaces.Count > 2)
                shipInstaces = new List<Ship>();

            shipInstaces.Add(transport);
            
            return transport;
        }
    }
    public class TrainTransportFactory : TransportFactory
    {
        public override Transport CreateTransport(string transportType)
        {
            Train transport = new Train();

            transport.Init();

            return transport;
        }
    }
}
