namespace Examples.Cargo;

public class UseLibrary
{
    public void TestCreateCargo()
    {
        var cargoFactory = new CargoFactory();
        cargoFactory.Create(new Train());
        cargoFactory.Create(AirCargo.Instance);
        cargoFactory.Create(new Ship("Iran" , "USA"));
        cargoFactory.Create(new Truck("123456789"));
    }
}