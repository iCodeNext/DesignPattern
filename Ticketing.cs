public class TicketService
{
    public ... Get(string ticketType)
    {
        if (ticketType == "Movie")
            return new ...();
        else if (ticketType == "Concert")
            return new ...();
        else if (ticketType == "Flight")
            return new ...();
        else
            throw new ArgumentException("Invalid ticket type.");
    }
}