using Examples.Interface;
using Examples.Service;

public class NotificationService()
{
    public INotificationService Get(string type)
    {
        if (type == "Email")
            return new EmailService();
        else if (type == "SMS")
            return new SMSService();
        //else if (type == "Push")
        //	return new ...();

        else
            throw new ArgumentException("Invalid notification type.");
    }
}
