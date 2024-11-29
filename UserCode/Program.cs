using System.Data.Common;
using Examples.E3;



CargoFactory cargoF = new CargoFactory(deliveryTypes =>
{
    deliveryTypes.Add("Truck",typeof(TruckCargo));
});



var deliveryCargo = cargoF.GetTypeOfCargoDelivery("air");
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
