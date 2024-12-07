namespace Payment
{
    public class CryptoPaymentDll
    {
        public CryptoPaymentDll() { }

        public void Payment(decimal amount)
        {
            Console.WriteLine("No adjustment for the selected payment method.");
            Console.WriteLine($"Processing cryptocurrency payment of ${amount} via third-party library");
        }
    }
}
