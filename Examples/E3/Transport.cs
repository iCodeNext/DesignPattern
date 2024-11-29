namespace Examples.E3
{
    public abstract class Transport
    {
        public abstract void Delivery();
    }
    public class AIR : Transport
    {
        public override void Delivery()
        {
            throw new NotImplementedException();
        }
    }
    public class Ship : Transport
    {
        public override void Delivery()
        {
            throw new NotImplementedException();
        }
    }

    public class Train : Transport
    {
        public void Init()
        {
            throw new NotImplementedException();
        }
        public override void Delivery()
        {
            throw new NotImplementedException();
        }
    }

}
