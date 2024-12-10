using Examples.BugReportingSystem.Connector;
using Examples.BugReportingSystem.Models;
using Examples.BugReportingSystem.Stages;

namespace Examples.BugReportingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new BugReportingModel()
            {
                Title = "Unauthorized",
                Description = "Can't login",
                ReporterName = "Ghazaleh",
                Severity = 5,
            };
            var bug = new BugReportingService();
            var connectors = new List<IConnector>
            {
                new JiraConnector(),
                new DiscordConnector()
            };

            bug.AddStage(new ValidationStage());
            bug.AddStage(new FormattingStage());
            bug.AddStage(new DispatchStage(connectors));

            bug.Proccess(model);
        }
    }
}
