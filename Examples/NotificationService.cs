using Examples.Interfaces;
using Examples.Services;

public class NotificationService()
{
    public INotificationService Get(string type)
    {
        return type switch
        {
            "SMS" => new SMS(),
            "Email" => new Email(),
            _ => throw new ArgumentException("Invalid notification type")
        };
    }
}
