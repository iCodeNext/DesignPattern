using Examples.BugReportingSystem.Models;

namespace Examples.BugReportingSystem.Connector
{
    public class JiraConnector : IConnector
    {
        public void Send(BugReportingModel input)
        {
            Console.WriteLine($"Report {input.Title}  sent with Jira");
        }
    }
}
