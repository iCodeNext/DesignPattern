using Examples;

public class NotificationService()
{
    public INotificationService Get(string type)
    {
        if (type == "Email")
            return new Email();
        else if (type == "SMS")
            return new SMS();
        //else if (type == "Push")
        //	return new ...();

        else
            throw new ArgumentException("Invalid notification type.");
    }
}
