namespace Payment.interfaces
{
    public interface IPaymentProcessorFactory
    {
        IPaymentProcessor CalculateDiscount(decimal amount);
    }
}
