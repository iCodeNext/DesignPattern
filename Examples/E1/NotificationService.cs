public class NotificationService()
{
    public object Get(string type)
    {
        if (type == "Email")
            return new();
        else if (type == "SMS")
            return new();
        //else if (type == "Push")
        //	return new ...();

        else
            throw new ArgumentException("Invalid notification type.");
    }
}
