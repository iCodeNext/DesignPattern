using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCode
{
    public class CargoService
    {
        public static IBook Send(string type)
        {
            if (type == "Air")
                return new AirFactory().CreateBook();
            else if (type == "Ship")
                return new ShipFactory("start location", "end location").CreateBook();
            else if (type == "Train")
                return new TrainFactory().CreateBook();

            throw new ArgumentException("Invalid type");

        }
    }


    public interface IBook
    {
        void Send();
    }
    public class Air : IBook
    {
        public void Send()
        {
            throw new NotImplementedException();
        }
    }
    public class Ship(string origin, string destination) : IBook
    {
        public string Origin { get; set; } = origin;
        public string Destination { get; set; } = destination;

        public void Send()
        {
            throw new NotImplementedException();
        }
    }
    public class Train : IBook
    {
        public void Send()
        {
            throw new NotImplementedException();
        }
        public void Initialize() { }
    }


    public interface IBookFactory
    {
        IBook CreateBook();
    }
    public class AirFactory : IBookFactory
    {
        public IBook CreateBook()
        {
            return new Air();
        }
    }
    public class ShipFactory(string origin, string destination) : IBookFactory
    {
        public string Origin { get; } = origin;
        public string Destination { get; } = destination;

        public IBook CreateBook()
        {
            return new Ship(Origin, Destination);
        }
    }
    public class TrainFactory : IBookFactory
    {
        public IBook CreateBook()
        {
            var trainPack = new Train();
            trainPack.Initialize();
            return trainPack;
        }
    }



    public class Program
    {
        public void Main()
        {
            string type = Console.ReadLine();
            CargoService.Send(type);
        }
    }
}

