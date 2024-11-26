using Examples.Ticket.Interface;

namespace Examples.Ticket;

public class ConcertTicket : ITicket
{
    public Task Buy() => Task.CompletedTask;
}