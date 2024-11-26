using Application.Core.Interfaces;
using Application.Infrastructure.Services;
using Application.Infrastructure.Services.NotificationServices;

public class NotificationService()
{
    public INotificationService Get(string type)
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
