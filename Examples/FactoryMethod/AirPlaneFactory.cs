namespace Examples.Cargo
{
    public class AirPlaneFactory : TransportFactory
    {
        private static AirPlaneFactory _airPlaneFactory; 
        private static readonly object _lock = new(); 
        private static AirPlane _airPlane;

        
        private AirPlaneFactory()
        {
        }

        public static AirPlaneFactory GetFactory()
        {
            if (_airPlaneFactory == null)
            {
                lock (_lock)
                {
                    if (_airPlaneFactory == null)
                    {
                        _airPlaneFactory = new AirPlaneFactory();
                    }
                }
            }
            return _airPlaneFactory;
        }

        public override ITransport Transfer()
        {
            throw new NotImplementedException();
        }
    }
}
