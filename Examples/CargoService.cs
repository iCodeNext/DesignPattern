using Examples.Cargo;

namespace Examples
{
    public class CargoService
    {
        public ITransfer Transfer(string type, string? origin, string? destination)
        {
            switch (type)
            {
                case "AIR":
                    return new AIRTransferFactory().Send();
                case "Ship":
                    return new ShipTransferFactory(origin, destination).Send();
                case "Train":
                    return new TrainTransferFactory().Send();
                default
                    :
                    throw new NotImplementedException();
            }

        }
    }
}
