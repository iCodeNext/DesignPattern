namespace Payment.Interfaces;

public interface IPaymentProcessorFactory
{
    IPaymentProcessor CreatePaymentProcessor(decimal amount);
}