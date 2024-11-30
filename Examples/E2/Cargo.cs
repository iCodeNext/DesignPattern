namespace Examples.E2;

public interface ITransfer
{
    void Transfer();
}

public class Air : ITransfer
{
    private static Air? instance { get; set; }

    private Air()
    {
    }

    public static Air Instance => instance ??= new Air();

    public void Transfer()
    {
    }
}

public class Ship : ITransfer
{
    public Ship(string source, string destination)
    {
    }

    public void Transfer()
    {
    }
}

public class Train : ITransfer
{
    public void Transfer()
    {
    }
}

public abstract class ConcreteTransfer
{
    public abstract ITransfer Transfer();
}

public class ConcreteAir : ConcreteTransfer
{
    public override ITransfer Transfer()
    {
        return Air.Instance;
    }
}

public class ConcreteShip : ConcreteTransfer
{
    public override ITransfer Transfer()
    {
        return new Ship("...", "...");
    }
}

public class ConcreteTrain : ConcreteTransfer
{
    public override ITransfer Transfer()
    {
        Init();
        return new Train();
    }
}

public class Program()
{
    public static void Main()
    {
        string type = "...";

        ConcreteTransfer concreteTransfer = type switch
        {
            "Air" => new ConcreteAir(),
            "Ship" => new ConcreteShip(),
            _ => new ConcreteTrain()
        };

        var transfer = CreateTransfer(concreteTransfer);
        transfer.Transfer();
    }

    static ITransfer CreateTransfer(ConcreteTransfer transfer)
    {
        return transfer.Transfer();
    }
}