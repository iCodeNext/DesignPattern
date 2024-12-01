public class TicketService
{
    public ITicketProvider Get(string ticketType)
    {
        if (ticketType == "Movie")
            return new MovieTicketProvider();
        else if (ticketType == "Concert")
            return new ConcertTicketProvider();
        else if (ticketType == "Flight")
            return new FlightTicketProvider();
        else
            throw new ArgumentException("Invalid ticket type.");
    }
}

public interface ITicketProvider
{
    public void Issue();
}

public class MovieTicketProvider : ITicketProvider
{
    public void Issue()
    {
        throw new NotImplementedException();
    }
}

public class ConcertTicketProvider : ITicketProvider
{
    public void Issue()
    {
        throw new NotImplementedException();
    }
}

public class FlightTicketProvider : ITicketProvider
{
    public void Issue()
    {
        throw new NotImplementedException();
    }
}