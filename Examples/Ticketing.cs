using Examples;

public class TicketService
{
    public ITicketService Get(string ticketType)
    {
        if (ticketType == "Movie")
            return new Movie();
        else if (ticketType == "Concert")
            return new Concert();
        else if (ticketType == "Flight")
            return new Flight();
        else
            throw new ArgumentException("Invalid ticket type.");
    }
}
