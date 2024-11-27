namespace Examples.E1.Models;

public abstract class BaseTicket
{
    public string TicketId { get; set; }
    public abstract TicketType Type { get; }
}

public enum TicketType : byte
{
    Movie = 1,
    Concert = 2,
    Flight = 3
}
