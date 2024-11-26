using Examples.Ticket.Interface;

namespace Examples.Ticket;

public class FlightTicket : ITicket
{
    public Task Buy() => Task.CompletedTask;
}