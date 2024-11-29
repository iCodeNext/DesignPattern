namespace Examples.Cargo;

public static class CargoFactory
{
    #region This Block is not in my base code it is 3rd Party
    public class Truck()
    {
        public void BookTruck(Guid truckId)
        {
            Console.WriteLine($"You have booked Truck: {truckId}");
        }
    } 
    #endregion
    public static IBook CreateBook(ShipmentTypes shipmentType, string Origin = null, string Destination = null, Guid truckId = default)
    {
        return shipmentType switch
        {
            ShipmentTypes.Air => AirCargo.Instance,
            ShipmentTypes.Ship => new Ship(Origin, Destination),
            ShipmentTypes.Train => new Train(),
            ShipmentTypes.Truck => new TruckAdapter(new Truck(), truckId),
            _ => throw new ArgumentException("Invalid shipment type")
        };
    }
}