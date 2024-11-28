namespace Examples.Cargo
{
    public class AirPlaneFactory : TransportFactory
    {
        private static AirPlane _airPlane;

        public ITransport Transport()
        {
            _airPlane ??= new AirPlane();
            return _airPlane;
        }
        public override ITransport Transfer()
        {
            throw new NotImplementedException();
        }
    }
}
