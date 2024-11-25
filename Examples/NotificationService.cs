using Examples.Contracts;
using Examples.Services;

public class NotificationService()
{
    public INotificationService Get(string type)
    {
        if (type == "Email")
            return new EmailService();
        else if (type == "SMS")
            return new SMSService();
        else if (type == "Push")
            return new PushNotificationService();

        else
            throw new ArgumentException("Invalid notification type.");
    }
}
