using Examples.Cargo;

namespace Examples.ExtendedCargo
{
    internal class Truck : ITransport
    {
        public void TransferPackage()
        {
            Console.WriteLine($"The Package will be sent via truck.");

        }
    }
}
