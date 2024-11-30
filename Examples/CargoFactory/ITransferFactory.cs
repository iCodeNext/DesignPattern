namespace Examples.Cargo
{
    public interface ITransferFactory
    {
        ITransfer Send();
        ITransfer Send(string origin, string destination);
    }
}
