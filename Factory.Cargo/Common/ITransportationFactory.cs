namespace Factory.Cargo.Factory;

public interface ITransportationFactory
{
    public ITransportation Create();
    public ITransportation Create(string origin, string destination);
}