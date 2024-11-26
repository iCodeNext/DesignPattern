using Examples.Interfaces;
using Examples.Services;

public class Ticketing
{
    public ITicketEvent Get(string ticketType)
    {
        if (ticketType == "Movie")
            return new MovieTicketEvent();
        else if (ticketType == "Concert")
            return new ConcertTicketEvent();
        else if (ticketType == "Flight")
            return new FlightTicketEvent();
        else
            throw new ArgumentException("Invalid ticket type.");
    }
}

