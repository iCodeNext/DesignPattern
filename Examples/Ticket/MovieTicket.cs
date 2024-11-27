using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Ticket
{
    public class MovieTicket : ITicket
    {
        public string GetDetails()
        {
            return "This is a movie ticket.";
        }
    }
}
