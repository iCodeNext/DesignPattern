namespace Payment.interfaces;
public interface IPaymentProcessor
{
    void Pay(decimal amount);
}
