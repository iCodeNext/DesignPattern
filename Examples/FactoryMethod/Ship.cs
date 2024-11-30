namespace Examples.Cargo
{
    public class Ship : ITransport
    {
        private readonly string _origin;
        private readonly string _destination;
        public Ship(string origin, string destination)
        {
            _origin = origin;
            _destination = destination;
        }
        public void Book()
        {
        }
    }
}
