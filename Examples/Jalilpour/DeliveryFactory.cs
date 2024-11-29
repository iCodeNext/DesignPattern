
namespace Examples.Jalilpour
{
    enum CargoType
    {
        Air,
        Ship,
        Train
    }

    public class DeliveryService
    {
        public Delivery Create(CargoType cargoType)
        {
            if (cargoType == CargoType.Air)
                return new Air();
            else if (cargoType == CargoType.Train)
                return new Train();
            else if (cargoType == CargoType.Ship)
                return new Ship();
            else
                throw new ArgumentException("Invalid Cargo Type");
        }
    }

    public abstract class Delivery
    {
        public abstract void DeliverCargo();
    }

    public class AirDelivery : Delivery
    {
        public override void DeliverCargo()
        {
            throw new NotImplementedException();
        }
    }

    public class TrainDelivery : Delivery
    {
        public override void DeliverCargo()
        {
            throw new NotImplementedException();
        }
    }

    public class ShipDelivery : Delivery
    {
        public override void DeliverCargo()
        {
            throw new NotImplementedException();
        }
    }

    public class Program()
    {
        public void main()
        {
            DeliveryFactory deliverFactory = new();
            var instance = deliverFactory.Create(CargoType.Air);
        }
    }

    public abstract class DeliveryFactory
    {
        public abstract Delivery CreateDelivery();
    }

    public class AirDeliveryFactory : DeliveryFactory
    {
        public override Delivery CreateDelivery()
        {

        }
    }

    public class ShipDeliveryFactory : DeliveryFactory
    {
        public override Delivery CreateDelivery()
        {

        }
    }

    public class TrainDeliveryFactory : DeliveryFactory
    {
        public override Delivery CreateDelivery()
        {

        }
    }
}
