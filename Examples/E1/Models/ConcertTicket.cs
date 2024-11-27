namespace Examples.E1.Models;

public class ConcertTicket : BaseTicket
{
    public override TicketType Type { get => TicketType.Concert; }
}
