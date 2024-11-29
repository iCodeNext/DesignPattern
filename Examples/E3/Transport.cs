namespace Examples.E3;

public interface ITransport
{
    public void Delivery();
}
public class Air : ITransport
{
    public void Delivery()
    {
        throw new NotImplementedException();
    }
}
public class Ship : ITransport
{
    public void Delivery()
    {
        throw new NotImplementedException();
    }
}

public class Train : ITransport
{
    public void Delivery()
    {
        throw new NotImplementedException();
    }

    public void Init()
    {
        Console.WriteLine("call Init (TrainFactory)");
    }
}
