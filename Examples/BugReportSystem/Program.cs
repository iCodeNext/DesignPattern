
var bugReport = new BugReport("Slow loading time on product pages", "The product pages are taking over 10 seconds to load. ", "medium", "Elahe Farokhi");

var platforms = new List<string> { "Discord", "Jira" };

var bugReportSystem = new BugReportSystem(platforms);

bugReportSystem.ProcessBugReport(bugReport);


public class BugReportSystem(List<string> platforms)
{
    private readonly IValidationStage _validationStage = new BugReportValidation();
    private readonly IFormattingStage _formattingStage = new BugReportFormatting();
    private readonly IDispatchStage _dispatchStage = new BugReportDispatcher(platforms);

    public void ProcessBugReport(BugReport report)
    {
        if (!_validationStage.Validate(report))
        {
            Console.WriteLine("Bug report processing failed due to validation errors.");
            return;
        }

        var formattedReport = _formattingStage.Format(report);

        _dispatchStage.Dispatch(formattedReport);

        Console.WriteLine("Bug report processed and dispatched successfully.");
    }
}

public interface IValidationStage
{
    bool Validate(BugReport report);
}

public class BugReportValidation : IValidationStage
{
    public bool Validate(BugReport report)
    {
        if (string.IsNullOrEmpty(report.Title) ||
            string.IsNullOrEmpty(report.Description) ||
            string.IsNullOrEmpty(report.Severity) ||
            string.IsNullOrEmpty(report.ReporterName))
        {
            Console.WriteLine("Bug report validation failed: Missing required fields.");
            return false;
        }
        return true;
    }
}

public interface IFormattingStage
{
    BugReport Format(BugReport report);
}

public class BugReportFormatting : IFormattingStage
{
    public BugReport Format(BugReport report)
    {
        report.Severity = report.Severity.ToUpper();

        report.Description += $"\nTimestamp: {DateTime.Now}";
        return report;
    }
}

public static class BugReportConnectorFactory
{
    public static IBugReportConnector CreateConnector(string platform)
    {
        return platform switch
        {
            "Jira" => new JiraAdapter(new JiraBugReporter()),
            "Slack" => new SlackAdapter(new SlackExternalService()),
            "Discord" => new DiscordAdapter(new DiscordExternalService()),
            _ => throw new ArgumentException("Unsupported platform")
        };
    }
}

public interface IDispatchStage
{
    void Dispatch(BugReport report);
}

public class BugReportDispatcher : IDispatchStage
{
    private readonly List<IBugReportConnector> _connectors;

    public BugReportDispatcher(List<string> platforms)
    {
        _connectors = [];
        foreach (var platform in platforms)
        {
            var connector = BugReportConnectorFactory.CreateConnector(platform);
            _connectors.Add(connector);
        }
    }

    public void Dispatch(BugReport report)
    {
        foreach (var connector in _connectors)
        {
            connector.SendBugReport(report);
        }
    }
}

public interface IBugReportConnector
{
    void SendBugReport(BugReport report);
}

public class JiraAdapter(JiraBugReporter jiraBugReporter) : IBugReportConnector
{
    public void SendBugReport(BugReport report)
    {
        jiraBugReporter.CreateIssue(report.Title, report.Description, report.Severity);
    }
}

public class SlackAdapter(SlackExternalService slackService) : IBugReportConnector
{
    public void SendBugReport(BugReport report)
    {
        slackService.PostMessageToChannel("bug-reports", $"Bug Report: {report.Title} - {report.Description}");
    }
}

public class DiscordAdapter(DiscordExternalService discordService) : IBugReportConnector
{
    public void SendBugReport(BugReport report)
    {
        discordService.SendMessageToChannel("bug-reports", $"Bug Report: {report.Title} - {report.Description}");
    }
}

public class BugReport(string title, string description, string severity, string reporterName)
{
    public string Title { get; set; } = title;
    public string Description { get; set; } = description;
    public string Severity { get; set; } = severity;
    public string ReporterName { get; set; } = reporterName;
}


#region External Services

public class JiraBugReporter
{
    public void CreateIssue(string title, string description, string severity)
    {
        Console.WriteLine($"Jira: Created an issue with Title: {title}, Severity: {severity}, Description: {description}");
    }
}

public class SlackExternalService
{
    public void PostMessageToChannel(string channel, string message)
    {
        Console.WriteLine($"Slack: Posted message to {channel}: {message}");
    }
}

public class DiscordExternalService
{
    public void SendMessageToChannel(string channel, string message)
    {
        Console.WriteLine($"Discord: Sent message to {channel}: {message}");
    }
}

#endregion