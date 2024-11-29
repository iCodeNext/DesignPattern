public class NotificationService()
{
    public INotificationService Get(string type)
    {
        if (type == "Email")
            return new EmailNotificationService();
        if (type == "SMS")
            return new SmsNotificationService();
        if (type == "Push")
            return new PushNotificationService();

        throw new ArgumentException("Invalid notification type.");
    }
}


public interface INotificationService
{
    void Send(string message);
}

public class EmailNotificationService : INotificationService
{
    public void Send(string message)
    {
        throw new NotImplementedException();
    }
}

public class SmsNotificationService : INotificationService
{
    public void Send(string message)
    {
        throw new NotImplementedException();
    }
}

public class PushNotificationService : INotificationService
{
    public void Send(string message)
    {
        throw new NotImplementedException();
    }
}