using Examples.Notification.Interface;

namespace Examples.Notification;

public class SmsService : INotification
{
    public Task Send() => Task.CompletedTask;
}