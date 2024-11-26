using Examples;
using Examples.Hobbies;

public class TicketService
{
    public Ihobbies Get(string ticketType)
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
