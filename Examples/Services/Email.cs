using Examples.Interfaces;

namespace Examples.Services;

public class Email : INotificationService 
{
    public Task NotifyAsync(string message)
    {
        throw new NotImplementedException();
    }
}