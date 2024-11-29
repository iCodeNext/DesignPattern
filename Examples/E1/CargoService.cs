using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.E1
{
    public class CargoService
    {
        private  CargoFactory CargoFactory { get; set; }
        private  string Origin =string.Empty;
        private  string Destination = string.Empty;
        public ICargo BookProduct(string type)
        {

            return CargoFactory.CreateCargoFactory(type,Origin,Destination);

        }
    }

    internal abstract class CargoFactory
    {
      public  ICargo CreateCargoFactory(string type,string origin,string destination)
        {
            CargoFactory factory =null ;
            if (type == "Air")
            {
                factory=  new AirFactory();
            }
            if (type == "Ship")
            {
                factory = new ShipFactory(origin,destination);
                
            }
            if (type == "Train")
            {
                factory = new TrainFactory();

            }
            if (factory is null)
                 throw new Exception("type is wrong");

            return factory.CreateCargo();
        }

        public abstract ICargo CreateCargo();
        
    }

    internal class TrainFactory : CargoFactory
    {
        public override ICargo CreateCargo()
        {
            var cargo = new Train();
            TrainMethod();
            return cargo;
        }

        private void TrainMethod()
        {
            throw new NotImplementedException();
        }
    }

    internal class ShipFactory : CargoFactory
    {
        public ShipFactory(string origin, string destination)
        {
            Origin = origin;
            Destination = destination;
        }

        public string Origin { get; set; }
        public string Destination { get; set; }
        public override ICargo CreateCargo()
        {
           return new Ship(Origin, Destination);
        }
    }

    internal class AirFactory : CargoFactory
    {
        private static Air Air { get; set; }
        public override ICargo CreateCargo()
        {
            if (Air is null) 
            {
            Air = new Air();
               
            }
            return Air;
        }
    }

    internal class Train : ICargo
    {

    }

    internal class Ship : ICargo
    {
        public Ship(string origin, string destination)
        {
            Origin = origin;
            Destination = destination;
        }

        public string Origin { get; }
        public string Destination { get; }
    }

    internal class Air : ICargo
    {

    }

    public interface ICargo
    {

    }
}
