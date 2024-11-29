namespace Examples.E3
{
    public class TransportService
    {
        private readonly TransportFactory transportFactory;

        public Transport Create(string transportType)
        {
            return transportFactory.CreateTransport(transportType);
        }
    }
}
