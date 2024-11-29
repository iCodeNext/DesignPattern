public class NotificationService()
{
    private readonly NotificationFactory notificationFactory;
    public Notification Get(string type)
    {
        //if (type == "Email")
        //    return new Email();
        //else if (type == "SMS")
        //    return new Sms();
        ////else if (type == "Push")
        ////	return new ...();

        //else
        //    throw new ArgumentException("Invalid notification type.");

        return notificationFactory.CreateNotification(type);
    }
}

public abstract class Notification
{
   public abstract void Send();
}
public class Email : Notification
{
    public override void Send()
    {
        throw new NotImplementedException();
    }
}
public class Sms : Notification
{
    public override void Send()
    {
        throw new NotImplementedException();
    }
}
public class Push( int number) : Notification
{
    public override void Send()
    {
        throw new NotImplementedException();
    }
}


public abstract class NotificationFactory
{
    public abstract Notification CreateNotification( string message);
}
public class EmailNotificationFactory : NotificationFactory
{
    List<EmailNotification> emailList = [];

    public override Notification CreateNotification(string message)
    {
        throw new NotImplementedException();
    }
}

public class SmsNotificationFactory : NotificationFactory
{
    Notification instance;

    public override Notification CreateNotification(string message)
    {
        instance = new Sms();
        return instance;
    }
}

public class PushNotificationFactory : NotificationFactory
{
    Notification instance;

    public override Notification CreateNotification(string message)
    {
        instance = new Push(5);
        return instance;
    }
}
