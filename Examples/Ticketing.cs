public class TicketService
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
