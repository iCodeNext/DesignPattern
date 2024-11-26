using Examples.Interfaces;
using Examples.Services;

public class TicketService
{
    public ITicketService Get(string ticketType)
    {
        return ticketType switch
        {
            "Flight" => new Flight(),
            "Concert" => new Concert(),
            "Movie" => new Movie(),
            _ => throw new ArgumentException("Invalid ticket type")
        };
    }
}
