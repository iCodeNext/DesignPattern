namespace Examples.E1.Models;

public class MovieTicket : BaseTicket
{
    public override TicketType Type { get => TicketType.Movie; }

}
