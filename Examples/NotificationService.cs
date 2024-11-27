using Examples.Notification;

public class NotificationService()
{
    public INotification Get(string type)
    {
        if (type == "Email")
            return new EmailNotification();
        else if (type == "SMS")
            return new SMSNotification();
        //else if (type == "Push")
        //	return new ...();

        else
            throw new ArgumentException("Invalid notification type.");
    }
}
