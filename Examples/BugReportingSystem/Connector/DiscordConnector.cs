using Examples.BugReportingSystem.Models;

namespace Examples.BugReportingSystem.Connector
{
    public class DiscordConnector : IConnector
    {
        public void Send(BugReportingModel input)
        {
            Console.WriteLine($"Report {input.Title} sent with Discord");
        }
    }
}
