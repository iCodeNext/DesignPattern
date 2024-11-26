using Examples.Ticket;
using Examples.Ticket.Interface;

namespace Examples;

public class Ticketing
{
    public ITicket Get(string ticketType)
    {
        if (ticketType == "Movie")
            return new MovieTicket();
        else if (ticketType == "Concert")
            return new ConcertTicket();
        else if (ticketType == "Flight")
            return new FlightTicket();
        else
            throw new ArgumentException("Invalid ticket type.");
    }
}