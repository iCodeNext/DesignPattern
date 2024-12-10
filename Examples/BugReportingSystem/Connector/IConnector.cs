using Examples.BugReportingSystem.Models;

namespace Examples.BugReportingSystem.Connector
{
    public interface IConnector
    {
        void Send(BugReportingModel input);
    }
}
