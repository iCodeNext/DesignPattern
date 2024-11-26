using Examples.Notification.Interface;

namespace Examples.Notification;

public class EmailService : INotification
{
    public Task Send() => Task.CompletedTask;
}