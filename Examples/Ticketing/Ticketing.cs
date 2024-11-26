namespace Examples.Ticketing;

public class TicketService
{
    public ITicket Get(string ticketType)
    {
        return ticketType switch
        {
            "Movie" => new MovieTicket(),
            "Concert" => new ConcertTicket(),
            "Flight" => new FlightTicket(),
            _ => throw new ArgumentException("Invalid ticket type.")
        };
    }
}