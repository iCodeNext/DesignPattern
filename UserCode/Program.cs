using System.Data.Common;
using Examples.E3;
CargoFactory cargoF = new CargoFactory();

CargoDeliveryLocations ShipTravelLocation = new CargoDeliveryLocations
    { 
        Origin = "Bandar-Abbas",
        Destination = "Qatar"
    };



cargoF.ConfigureDeliveryTypes(deliveryTypes =>
{
    deliveryTypes.Add(new TrainCargo());
    deliveryTypes.Add(new ShipCargo(ShipTravelLocation));
    deliveryTypes.Add(AirCargo.Instance);
    deliveryTypes.Add(new TruckCargo()); // ForExample Developer want to Consider new behavior called TruckCargo
});


var deliveryCargo = cargoF.GetTypeOfCargoDelivery("TruckCargo");
deliveryCargo.Book();


#region NewBehavior
    public class TruckCargo : ICargo
    {
        public void Book()
        {
            Console.WriteLine("Booking Via Truck....");
        }
    }
#endregion
