using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Jalilpour
{
    public class CargoService
    {
        public object DeliverCargo(string cargoType)
        {
            if (cargoType == "Air")
                return new AirService();
            else if (cargoType == "Ship")
                return new TrainService();
            else if (cargoType == "Trin")
                return new ShipService();
            else
                throw new ArgumentException("Invalid Cargo Type");
        }
    }

    public class AirService
    {

    }

    public class TrainService
    {

    }

    public class ShipService
    {

    }
}
