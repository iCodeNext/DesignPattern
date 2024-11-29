
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
            {
                return new AirDeliveryFactory().CreateDelivery();
            }
            else if (cargoType == CargoType.Ship)
            {
                return new ShipDeliveryFactory().CreateDelivery();
            }
            else if (cargoType == CargoType.Train)
            {
                return new TrainDeliveryFactory().CreateDelivery();
            }
            throw new InvalidArgumentException();
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


    public abstract class DeliveryFactory
    {
        public abstract Delivery CreateDelivery();
    }

    public class AirDeliveryFactory : DeliveryFactory
    {
        private static AirDelivery airDelivery;
        public override Delivery CreateDelivery()
        {
            if (airDelivery == null)
                airDelivery = new AirDelivery();
            return airDelivery;
        }
    }

    public class ShipDeliveryFactory : DeliveryFactory
    {
        public override Delivery CreateDelivery()
        {
            return new ShipDelivery();
        }
    }

    public class TrainDeliveryFactory : DeliveryFactory
    {
        public override Delivery CreateDelivery()
        {
            return new TrainDelivery();
        }
    }


    public class Program()
    {
        public void main()
        {
            DeliveryService deliverFactory = new();
            var instance = deliverFactory.Create(CargoType.Air);
            instance.DeliverCargo();
        }
    }
}
