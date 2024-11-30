using Examples.Cargo;

namespace Examples
{
    public class CargoService
    {
        public ITransfer Get(string type, string? origin, string? destination)
        {
            switch (type)
            {
                case "AIR":
                    return new AIRTransferFactory();
                    break;
                case "Ship":
                    return new ShipTransferFactory(origin, destination);
                    break;
                case "Train":
                    return new TrainTransferFactory();
                    break;
            }
        }
    }
}
