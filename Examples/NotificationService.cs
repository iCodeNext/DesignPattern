using Examples.Notification;
using Examples.Notification.Interface;

namespace Examples;

public class NotificationService()
{
    public INotification Get(string type)
    {
        if (type == "Email")
            return new EmailService();
        else if (type == "SMS")
            return new SmsService();
        //else if (type == "Push")
        //	return new ...();
        else
            throw new ArgumentException("Invalid notification type.");
    }
}