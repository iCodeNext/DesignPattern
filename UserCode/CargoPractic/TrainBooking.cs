using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCode.CargoPractic
{
    public class TrainBooking : IBooking
    {
        private bool IsHealthCheck = false;

        public void DoHealthCheck()
        {
            IsHealthCheck = true;
        }
        public string DoBook()
        {
            if (IsHealthCheck == false)
            {
                throw new Exception("The Train Health No Checked Yet!");
            }

            return "Train Booking Was Successfully";
        }
    }
}
