using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.E3
{
    public interface ICargo
    {
        public void Book();
    }
    public struct ShipCargoLocations
    {
        public string Origin;
        public string Destination;
    }


    #region AirCargo
    // Im Gonna Use SingleTone Design
    // For Instance OBJ I Used Lazy<>() Cause Its:  1-Thread Safe   2-Return Created Object Not new obj    3-Create Obj When We Need Them
    public sealed class AirCargo : ICargo
    {
        private AirCargo()
        {
        }

        private static readonly Lazy<AirCargo> instance = new Lazy<AirCargo>(() => new AirCargo());

        public static AirCargo Instance => instance.Value;

        public void Book()
        {
            Console.WriteLine("Booking via Air Cargo....");
        }
    }

    #endregion

    #region ShipCargo
    public class ShipCargo : ICargo
    {
        private readonly ShipCargoLocations _locations;

        // Using Struct For Constructor 
        public ShipCargo(ShipCargoLocations locations)
        {
            _locations = locations;
        }
        public void Book()
        {
            if (_locations.Origin is null || _locations.Destination is null)
            {
                Console.WriteLine("Please Specify Locations First");
                return;
            }

            Console.WriteLine($"Booking Via Ship Cargo From {_locations.Origin} To {_locations.Destination}");
        }
    }
    #endregion

    #region TrainCargo

    // Considering Init Method Because it is a Part of Task
    public class TrainCargo : ICargo
    {
        public bool IsInitialized = false;

        public void Init() => IsInitialized = true;
        public void Book()
        {
            if (!IsInitialized)
                throw new InvalidOperationException("First Invoke Initialize Method, Then Invoke Book Method");
            Console.WriteLine("Booking Via TrainCargo....");
        }
    }

    #endregion
    public class CargoFactory
    {
        public ICargo GetTypeOfCargoDelivery(string cargoDeliveryType, ShipCargoLocations? locations = null)
        {
            return cargoDeliveryType switch
            {
                "Air" => AirCargo.Instance,

                "Ship" => locations is null
                    ? throw new ArgumentNullException(nameof(locations), "You Must Pass Locations")
                    : new ShipCargo((ShipCargoLocations)locations),

                "Train" => new TrainCargo()
            };
        }
    }


}
