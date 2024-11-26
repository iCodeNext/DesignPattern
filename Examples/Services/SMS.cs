using Examples.Interfaces;

namespace Examples.Services;

public class SMS : INotificationService
{
    public Task NotifyAsync(string message)
    {
        throw new NotImplementedException();
    }
}