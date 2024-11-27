public class TicketService
{
    public ITicket Get(string ticketType)
    {
        if (ticketType == "Movie")
            return new MovieTiket();
        else if (ticketType == "Concert")
            return new ContactTiket();
        else if (ticketType == "Flight")
            return new FilghtTiket();
        else
            throw new ArgumentException("Invalid ticket type.");
    }
}
