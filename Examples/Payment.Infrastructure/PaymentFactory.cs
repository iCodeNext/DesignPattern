using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payment.Core;

namespace Payment.Infrastructure
{
    public class PaymentFactory
    {
        private Dictionary<string, Type> _payments = new();

        public PaymentFactory(Action<Dictionary<string, Type>> payments)
        {
            payments(_payments);
        }

        public IPaymentProcessor GetPayment(string paymentId)
        {
            var payment = _payments.Keys.Contains(paymentId) ? _payments[paymentId] : null;
            if (payment == null)
                return null;
            return (IPaymentProcessor)Activator.CreateInstance(payment);
        }
    }
}
