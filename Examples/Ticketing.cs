namespace Examples;
public class TicketService
{
    public string Get(ITicketType ticketType)
    {
        if(ticketType is null) throw new ArgumentNullException("ticketType is null.");
        return ticketType.GenerateTicket();
    }
}
