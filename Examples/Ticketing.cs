namespace Examples
{
    public class Ticketing
    {
        public ITicketing ReserveTicketing(string type)
        {
            return type switch
            {
                "Cinema" => new Cinema(),
                "Flight" => new Flight(),
                "Concert" => new Concert(),
                _ => throw new ArgumentException($"The Ticket type {type} is Invalid"),
            };
        }
    }
}
