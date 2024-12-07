using Payment.enumModel;
using Payment.PaymentService;

namespace MyApp;

internal class Program
{
    static void Main(string[] args)
    {
        new PaymentService().DoPayment(PaymentType.PayPal, 100000);
        new PaymentService().DoPayment(PaymentType.CryptoCurrency, 100000);
        new PaymentService().DoPayment(PaymentType.CreditCard, 100000);
        new PaymentService().DoPayment(new PaymentType(), 100000);
    }
}

