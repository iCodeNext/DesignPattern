namespace Payment.Interfaces;

public interface IPaymentProcessor
{
    void Pay(decimal amount);
}