using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.E3
{

    public class Cargo
    {
        public IShipping Send(string shippingType)
        {
            if (shippingType == "Air")
                return new AirFactory().CreateShipping();
            else if (shippingType == "Ship")
                return new ShipFactory("", "").CreateShipping();
            else if (shippingType == "Train")
                return new TrainFactory().CreateShipping();

            else
                throw new ArgumentException("Invalid Shipping type.");
        }
    }

    public interface IShipping
    {
        void Send();
    }

    public class Air : IShipping
    {
        public void Send()
        {
        }
    }


    public class Ship : IShipping
    {
        private readonly string _origin;
        private readonly string _destination;

        public Ship(string origin, string destination)
        {
            _origin = origin;
            _destination = destination;
        }

        public void Send()
        {
        }
    }


    public class Train : IShipping
    {
        public void Send()
        {
        }
    }
    public class Truck : IShipping
    {
        public void Send()
        {
        }
    }
    public interface IShippingFactory
    {
        IShipping CreateShipping();
    }

    public class AirFactory : IShippingFactory
    {
        private static Air _air;

        public IShipping CreateShipping()
        {
            if (_air == null)
            {
                _air = new Air();
            }

            return _air;
        }
    }

    public class ShipFactory : IShippingFactory
    {

        private readonly string _origin;
        private readonly string _destination;

        public ShipFactory(string origin, string destination)
        {
            _origin = origin;
            _destination = destination;
        }

        public IShipping CreateShipping()
        {
            return new Ship(_origin, _destination);
        }

    }
    public class TrainFactory : IShippingFactory
    {

        public IShipping CreateShipping()
        {
            Train train = new Train();
            Call();
            return train;
        }
        private void Call()
        {
        }
    }
    public class TruckFactory : IShippingFactory
    {

        public IShipping CreateShipping()
        {
            return new Truck();
        }
    }
}

