using Examples.E1.Contracts;
using Examples.E1.Services;

namespace Examples.E1;

public class NotificationService
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
