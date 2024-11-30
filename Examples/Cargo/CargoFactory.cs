namespace Examples.Cargo;

public class CargoFactory : ICargo
{
    // public Create(IShipping shipping, string Origin = null, string Destination = null)
    // {
    //     // return shipping switch
    //     // {
    //     // ShipmentTypes.Air => AirCargo.Instance,
    //     // ShipmentTypes.Ship => new Ship(Origin, Destination),
    //     // ShipmentTypes.Train => new Train(),
    //     // _ => throw new ArgumentException("Invalid shipment type")
    //     // };
    // }

    // public IShipping Shipping { get; set; }

    public void Create(IShipping shipping)
    {
        // Shipping = shipping;

        shipping.PrintDetail();
    }
}