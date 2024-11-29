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
        private List<ICargo> CargoDeliveryTypes = new();

        //Consider Configuration Method To Add DeliveryTypes To CargoDeliveryTypes
        public void ConfigureDeliveryTypes(Action<List<ICargo>> deliveryTypes)
        {
            deliveryTypes(CargoDeliveryTypes);
        }

        public ICargo GetTypeOfCargoDelivery(string cargoDeliveryType)
        {

            foreach (ICargo DeliveryType in CargoDeliveryTypes)
            {
                Type type = DeliveryType.GetType();

                if (type.Name == cargoDeliveryType)
                    return DeliveryType;
            }

            throw new Exception(
                $"Could not find {cargoDeliveryType}, How to solve: Make sure that you added delivery type in Configuration Method");

        }
    }


}
