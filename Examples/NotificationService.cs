using Examples;

public class NotificationService()
{
    public IProviderSender Get(string type)
    {
        if (type == "Email")
            return new EmailSender();
        else if (type == "SMS")
            return new SmsSender();
        //else if (type == "Push")
        //	return new ...();

        else
            throw new ArgumentException("Invalid notification type.");
    }
}
