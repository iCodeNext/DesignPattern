namespace Examples.E2;


public interface INotificationService
{
    void Send(string message);
}



public class EmailNotification : INotificationService
{
    public void Send(string message) => Console.WriteLine($"Email sent: {message}");
}

public class SmsNotification : INotificationService
{
    public void Send(string message) => Console.WriteLine($"SMS sent: {message}");
}

#region Thid block of code is not in your code base, it is a library(3rd party)
public class SlackNotification
{
    public void PostMessageToChannel(string channel, string message)
    {
        Console.WriteLine($"Message sent to Slack channel {channel}: {message}");
    }
}
#endregion

public class SlackNotidicationService(string channel) : INotificationService
{
    private readonly SlackNotification _slackNotification;
    public void Send(string message)
    {
        _slackNotification.PostMessageToChannel(channel, message);
    }
}



public class NotificationService()
{
    public INotificationService Get(string type, string channel = null)
    {
        if (type == "Email")
            return new EmailNotification();
        else if (type == "SMS")
            return new SmsNotification();
        else if (type == "Slack")
            return new SlackNotidicationService(channel);

        else
            throw new ArgumentException("Invalid notification type.");
    }
}
