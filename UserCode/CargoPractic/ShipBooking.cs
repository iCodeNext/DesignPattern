using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCode.CargoPractic
{
    public class ShipBooking(string origin, string destination) : IBooking
    {
        public string DoBook()
        {
            return $"Booked Successfully From {origin} To {destination}";
        }
    }
}
