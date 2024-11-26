using Examples.Ticket.Interface;

namespace Examples.Ticket;

public class MovieTicket : ITicket
{
    public Task Buy() => Task.CompletedTask;
}