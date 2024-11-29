using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Jalilpour
{
    public class DeliverFactory
    {
        public Deliver Create(string cargoType)
        {
            if (cargoType == "Air")
                return new Air();
            else if (cargoType == "Ship")
                return new Train();
            else if (cargoType == "Trin")
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
}
