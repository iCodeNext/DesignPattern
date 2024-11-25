using Examples.Interface;
using Examples.Service;

public class TicketService
{
    public ITicketingService Get(string ticketType)
    {
        if (ticketType == "Movie")
            return new MovieService();
        else if (ticketType == "Concert")
            return new ConcertService();
        else if (ticketType == "Flight")
            return new FlightService();
        else
            throw new ArgumentException("Invalid ticket type.");
    }
}
