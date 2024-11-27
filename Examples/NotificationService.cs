public class NotificationService()
{
    public INotiFication Get(string type)
    {
        if (type == "Email")
            return new EmailNotification();
        else if (type == "SMS")
            return new SmsNotification();
        //else if (type == "Push")
        //	return new ...();

        else
            throw new ArgumentException("Invalid notification type.");
    }
}
