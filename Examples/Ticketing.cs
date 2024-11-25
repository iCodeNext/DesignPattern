using Examples.Contracts;
using Examples.Models;

public class TicketService
{
    public BaseTicket Get(string ticketType)
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
