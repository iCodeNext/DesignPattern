public class NotificationService
{
    public INotificationService PushNotification(string type)
    {
        return type switch
        {
            "Email" => new EmailService(),
            "Sms" => new SmsService(),
            _ => throw new ArgumentException($"The Notification type{type} is Invalid"),
        };
    }
}