using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examples.Example2.Intrface;

namespace Examples.Example2.Transport
{
    public class TrainTransport : ITransport
    {
        private bool _isInitialized = false;

        public void Initialize()
        {
            _isInitialized = true;
            Console.WriteLine("Train is initialized and ready.");
        }

        public void Book(string packageDetails)
        {
            if (!_isInitialized)
            {
                throw new InvalidOperationException("Train is not initialized. Please initialize first.");
            }
            Console.WriteLine($"Package booked via TRAIN: {packageDetails}");
        }
    }
}
