using Examples.Interfaces;
using Examples.Services;

public class NotificationService()
{
    public INotificationSender Get(string type)
    {
        if (type == "Email")
            return new EmailNotificationSender();
        else if (type == "SMS")
            return new SmsNotificationSender();
        //else if (type == "Push")
        //	return new ...();

        else
            throw new ArgumentException("Invalid notification type.");
    }

}
