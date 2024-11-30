using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.E2
{
    public interface INotification
    {
        void Send(string message);
    }

    public class EmailNotification : INotification
    {
        public void Send(string message) => Console.WriteLine($"Email sent: {message}");
    }

    public class SmsNotification : INotification
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

    //i  used adapter pattern or wrapper pattern
    public class SlackNotificationAddapter : INotification
    {
        private readonly SlackNotification _slackNotification;
        public SlackNotificationAddapter()
        {
            _slackNotification = new SlackNotification();
        }
        public void Send(string message)
        {
            _slackNotification.PostMessageToChannel("chanelA", message);
        }
    }


    #endregion


    public class NotificationService()
    {
        public INotification Get(string type)
        {
            if (type == "Email")
                return new EmailNotification();
            else if (type == "SMS")
                return new SmsNotification();
            else if (type == "Slack")
                return new SlackNotificationAddapter();
            else
                throw new ArgumentException("Invalid notification type.");


        }
    }
}
