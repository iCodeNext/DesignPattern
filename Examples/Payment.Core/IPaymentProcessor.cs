using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Core
{
    public interface IPaymentProcessor
    {
        public void Process(float price);
    }
}
