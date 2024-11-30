using System.Runtime.CompilerServices;
using static NotificationService;

public class NotificationService()
{
    private readonly NotificationFactory notificationFactory;
    public Notification Create(string type)
    {
        if (type == "Email")
            return new EmailFactory().CreateNotification();
        else if (type == "SMS")
            return new SmsFactory().CreateNotification();

        throw new Exception();
        //return notificationFactory.CreateNotification();
    }
    public abstract class Notification
    {
        public abstract void Send(string message);
    }

    public class Email : Notification
    {
        public override void Send(string message)
        {
            throw new NotImplementedException();
        }
    }
    public class Sms : Notification
    {
        public override void Send(string message)
        {
            throw new NotImplementedException();
        }
    }

    public abstract class NotificationFactory
    {
        public abstract Notification CreateNotification();
    }
    public class EmailFactory : NotificationFactory
    {
        List<Email> emails = new List<Email>();
        public override Notification CreateNotification()
        {
            return null;
        }
    }
    public class SmsFactory : NotificationFactory
    {
        public override Notification CreateNotification()
        {
            var notif = new Sms();
            return notif;   
        }
    }


}
public class Program
{
    public void Main(string[] args)
    {
        
    }
}
