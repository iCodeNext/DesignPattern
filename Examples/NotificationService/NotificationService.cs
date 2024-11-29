namespace Examples.NotificationService;

public class NotificationService()
{
    public INotification Get(string type)
    {
        return type switch
        {
            "Email" => new EmailNotification(),
            "SMS" => new SmsNotification(),
            _ => throw new ArgumentException("Invalid notification type.")
        };
    }
}