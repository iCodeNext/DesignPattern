using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
using System.Reflection;

public class Program
{
	public static void Main()
	{
		// DI
		var serviceProvider = ConfigureServices();
		var connectors = serviceProvider.GetRequiredService<Connectors>();

		Console.Write("Enter Title: ");
		var title = Console.ReadLine();

		Console.Write("Enter Description: ");
		var description = Console.ReadLine();

		Console.Write("Enter Severity(Dangerous, Medium, LowImportance): ");
		var severityInput = Console.ReadLine();
		var severity = Enum.TryParse(severityInput, out Severity parsedSeverity) ? parsedSeverity : Severity.LowImportance;

		var report = new BugReport
		{
			Title = title,
			Description = description,
			Severity = severity
		};

		report.Validate();

		Console.Write("Enter Connector (Discord, Jira, Slack): ");
		var connectorType = Console.ReadLine();

		 connectors.Create(connectorType);
	}

	// Config DI
	private static ServiceProvider ConfigureServices()
	{
		return new ServiceCollection()
			.AddTransient<IConnectorsFactory, DiscordFactory>()
			.AddTransient<IConnectorsFactory, SlackFactory>()
			.AddTransient<IConnectorsFactory, JiraFactory>()
			.AddTransient<Connectors>()
			.BuildServiceProvider();
	}
}

public class Connectors
{
	private readonly IEnumerable<IConnectorsFactory> _factories;

	public Connectors(IEnumerable<IConnectorsFactory> factories)
	{
		_factories = factories;
	}

	public IConnectors Create(string connectorType)
	{
		var factory = _factories.FirstOrDefault(f => f.GetType().Name.ToLower().Contains(connectorType));
		return factory?.CreateInstance();
	}
}

public class BugReport
{
	public string Title { get; init; } = default!;
	public string Description { get; init; } = default!;
	public Severity Severity { get; init; }
	public DateTime CreationDate { get;} = DateTime.UtcNow;

	public void Validate()
	{
		if (string.IsNullOrWhiteSpace(Title))
			throw new ArgumentException("Title cannot be null, empty, or whitespace.", nameof(Title));

		if (string.IsNullOrWhiteSpace(Description))
			throw new ArgumentException("Description cannot be null, empty, or whitespace.", nameof(Description));
	}

	public string Format()
	{
		var severityLabel = Severity.GetDescription();
		return $"[{severityLabel}] {Title}: {Description} (Created On: {CreationDate:yyyy-MM-dd HH:mm:ss})";
	}
}

public enum Severity
{
	[Description("High")]
	Dangerous = 0,
	[Description("Medium")]
	Medium = 1,
	[Description("Low")]
	LowImportance = 2
}

public static class EnumExtensions
{
	public static string GetDescription(this Enum value)
	{
		var field = value.GetType().GetField(value.ToString());
		var attribute = field!.GetCustomAttribute<DescriptionAttribute>();
		return attribute == null ? value.ToString() : attribute.Description;
	}
}

public interface IConnectors
{
	void SendBugReport(BugReport report);
}

public class Jira : IConnectors
{
	public void SendBugReport(BugReport report)
	{
		Console.WriteLine($"[Jira] Bug Report Sent: {report.Format()}");
	}
}

public class Slack : IConnectors
{
	public void SendBugReport(BugReport report)
	{
		Console.WriteLine($"[Slack] Bug Report Sent: {report.Format()}");
	}
}

public class Discord : IConnectors
{
	public void SendBugReport(BugReport report)
	{
		Console.WriteLine($"[Discord] Bug Report Sent: {report.Format()}");
	}
}

public interface IConnectorsFactory
{
	IConnectors CreateInstance();
}

public class JiraFactory : IConnectorsFactory
{
	public IConnectors CreateInstance()
	{
		return new Jira();
	}
}

public class SlackFactory : IConnectorsFactory
{
	public IConnectors CreateInstance()
	{
		return new Slack();
	}
}

public class DiscordFactory : IConnectorsFactory
{
	public IConnectors CreateInstance()
	{
		return new Discord();
	}
}

