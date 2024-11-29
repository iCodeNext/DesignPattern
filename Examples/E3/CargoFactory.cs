namespace Examples.E3
{
    public interface ICargo
    {
        public void Book();
    }
    public struct CargoDeliveryLocations
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
        private readonly CargoDeliveryLocations _locations;

        // Using Struct For Constructor 
        public ShipCargo(CargoDeliveryLocations locations)
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
        private bool _isInitialized = false;

        public void Init() => _isInitialized = true;
        public void Book()
        {
            if (!_isInitialized)
                throw new InvalidOperationException("First Invoke Initialize Method, Then Invoke Book Method");
            Console.WriteLine("Booking Via TrainCargo....");
        }
    }

    #endregion
    public class CargoFactory
    {
        private readonly Dictionary<string, Type> _deliveryTypes;

        //Problem:
        //it is linear. O(n).
        //it is not a good idea to iterate over a list and hold the all references..
        // ********Dictionaries don't need iteration********
        public CargoFactory(Action<Dictionary<string, Type>> deliveryTypes)
        {
            _deliveryTypes = new();
            deliveryTypes(_deliveryTypes);
        }

        public ICargo GetTypeOfCargoDelivery(string cargoDeliveryType)
        {
            
            if (_deliveryTypes.TryGetValue(cargoDeliveryType, out Type type))
            {
                // We Create Instance only when developer need it
                return (ICargo)Activator.CreateInstance(type)!;
            }


            throw new Exception(
                $"Could not find {cargoDeliveryType}, How to solve: Make sure that you added delivery type in constructor");

        }
    }


}
