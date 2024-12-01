
namespace Examples.Jalilpour
{
    public enum CargoType
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
            throw new InvalidOperationException();
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
        public ShipDelivery()
        {

        }
        public ShipDelivery(string origin, string destination)
        {

        }
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
            return new ShipDelivery("BandarAbbas", "Astarakhan");
        }
    }

    public class TrainDeliveryFactory : DeliveryFactory
    {
        private static bool hasAlreadyInstance;
        public override Delivery CreateDelivery()
        {
            if (hasAlreadyInstance)
            {
                init();
                return new TrainDelivery();
            }
            else
            {
                hasAlreadyInstance = true;
                return new TrainDelivery();
            }
        }
        private void init()
        {
            throw new NotImplementedException();
        }
    }



    /// <summary>
    /// Imagine it is a library and we make it as a package. so users or customers,
    /// can't change your code, but they want to add a new behavior like Truck. so, how you can solve it.
    /// </summary>
    public class Truck : Delivery
    {
        public override void DeliverCargo()
        {
            Console.WriteLine("Delivering...");
        }
    }
    public static class DeliveryFactoryExtentionMethod
    {
        public static void DeliverCargoByTruck(this Delivery truck)
        {
            throw new NotImplementedException();
        }
    }
    ///


    public class Program()
    {
        public void main()
        {
            Truck truck = new();
            truck.DeliverCargoByTruck();
        }
    }
}
