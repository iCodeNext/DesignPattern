using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Jalilpour
{
    enum CargoType
    {
        Air,
        Ship,
        Train
    }

    public class DeliverFactory
    {
        public Deliver Create(CargoType cargoType)
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

    public class Deliver
    {

    }

    public class Air : Deliver
    {

    }

    public class Train : Deliver
    {

    }

    public class Ship : Deliver
    {

    }

    public class Program()
    {
        public void main()
        {
            DeliverFactory deliverFactory = new();
            var instance = deliverFactory.Create(CargoType.Air);
        }
    }
}
