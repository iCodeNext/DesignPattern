using Examples.Cargo;

namespace Examples.ExtendedCargo
{
    //Extending via composition
    public class ExtendedCargoManager(CargoManager cargoManager)
    {

        public ITransport GetTransport(ExtendedTransportType type, string origin = "", string destination = "")
        {
            return type switch
            {
                ExtendedTransportType.Truck => CreateTruckTransport(),
                _ => cargoManager.GetTransport((TransportType)type, origin, destination)
            };
        }

        private ITransport CreateTruckTransport()
        {
            var truckFactory = new TruckFactory();
            return truckFactory.CreateTransport();
        }

    }
}
