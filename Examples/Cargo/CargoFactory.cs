namespace Examples.Cargo;

public static class CargoFactory
{
    public static IBook CreateBook(ShipmentTypes shipmentType, string Origin = null, string Destination = null)
    {
        return shipmentType switch
        {
            ShipmentTypes.Air => AirCargo.Instance,
            ShipmentTypes.Ship => new Ship(Origin, Destination),
            ShipmentTypes.Train => new Train(),
            _ => throw new ArgumentException("Invalid shipment type")
        };
    }
}