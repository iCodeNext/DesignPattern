using Payment.interfaces;
using Payment.PaymentMethods;

namespace Payment.PaymentMethodsFactory
{
    public class CreditCardPaymentProcessorFactory : IPaymentProcessorFactory
    {
        public IPaymentProcessor CalculateDiscount(decimal amount)
        {
            Console.WriteLine("Applying 2% fee for credit card payment.");
            var creditCard = new CreditCardPaymentProcessor();
            creditCard.Pay(CalculateNewAmountForCreditCard(amount));
            return creditCard;
        }
        private static decimal CalculateNewAmountForCreditCard(decimal amount)
        {
            amount += amount * (decimal)0.02;
            return amount;
        }
    }
}
