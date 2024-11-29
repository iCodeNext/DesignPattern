
namespace Examples.Jalilpour
{
    enum CargoType
    {
        Air,
        Ship,
        Train
    }

    public class DeliveryFactory
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
        abstract void DeliverCargo();
    }

    public class Air : Delivery
    {
        private override void DeliverCargo()
        {
            throw new NotImplementedException();
        }
    }

    public class Train : Delivery
    {
        private override void DeliverCargo()
        {
            throw new NotImplementedException();
        }
    }

    public class Ship : Delivery
    {
        private override void DeliverCargo()
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
}
