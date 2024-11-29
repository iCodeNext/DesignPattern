using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCode.CargoPractic
{
    public class AirBooking : IBooking
    {
        public static AirBooking? Instance;
        private AirBooking()
        {
            Instance = new AirBooking();
        }
        public string DoBook()
        {
            return $"Air Booking Was Successfully";
        }
    }
}
