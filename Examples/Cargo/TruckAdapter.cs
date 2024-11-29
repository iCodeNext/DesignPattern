namespace Examples.Cargo;

public class TruckAdapter : IBook
{
    private readonly CargoFactory.Truck _truck;
    private readonly Guid _truckId;

    public TruckAdapter(CargoFactory.Truck truck, Guid truckId)
    {
        _truck = truck;
        _truckId = truckId;
    }
    public void Book()
    {
        _truck.BookTruck(_truckId);
    }
}