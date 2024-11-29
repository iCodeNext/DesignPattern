// public interface INotification
// {
//     void Send(string message);
// }
//
// public class EmailNotification : INotification
// {
//     public void Send(string message) => Console.WriteLine($"Email sent: {message}");
// }
//
// public class SmsNotification : INotification
// {
//     public void Send(string message) => Console.WriteLine($"SMS sent: {message}");
// }
//
// #region Thid block of code is not in your code base, it is a library(3rd party)
// public class SlackNotification
// {
//     public void PostMessageToChannel(string channel, string message)
//     {
//         Console.WriteLine($"Message sent to Slack channel {channel}: {message}");
//     }
// } 
// #endregion
//
// public class NotificationService()
// {
//     public ... Get(string type)
//     {
//         if (type == "Email")
//             return new ...();
//         else if (type == "SMS")
//             return new ...();
//         else if (type == "Slack")
//             return new ...();
//
//         else
//             throw new ArgumentException("Invalid notification type.");
//     }
// }
