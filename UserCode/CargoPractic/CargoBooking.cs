namespace UserCode.CargoPractic;

public static class CargoBooking
{
    public static IBooking? BookOperation(this ShippingType shippingType, string from = "", string to = "")
    {
        if (Enum.IsDefined(typeof(ShippingType), shippingType) == false)
            throw new Exception("Please Select a Valid ShippingType");

        IBooking? booking = shippingType switch
        {
            ShippingType.Train => new TrainBooking(),
            ShippingType.Air => AirBooking.Instance,
            ShippingType.Ship => new ShipBooking(from, to),
            _ => throw new NotImplementedException()
        };
        return booking;
    }
}
