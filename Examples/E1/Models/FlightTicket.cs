namespace Examples.E1.Models;

public class FlightTicket : BaseTicket
{
    public override TicketType Type { get => TicketType.Flight; }
}
