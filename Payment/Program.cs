using System;

namespace ChainOfResponsibilityExample;


public class SupportTicket
{
    public string Issue { get; }
    public int Severity { get; }

    public SupportTicket(string issue, int severity)
    {
        Issue = issue;
        Severity = severity; // 1 = Basic, 2 = Technical, 3 = Managerial
    }
}

// Abstract Handler
public abstract class SupportHandler
{
    protected SupportHandler? NextHandler { get; set; }

    public void SetNext(SupportHandler handler)
    {
        NextHandler = handler;
    }

    public void Handle(SupportTicket ticket)
    {
        if (CanHandle(ticket))
        {
            Process(ticket);
        }
        else if (NextHandler != null)
        {
            Console.WriteLine($"{GetType().Name} passed the ticket to {NextHandler.GetType().Name}");
            NextHandler.Handle(ticket);
        }
        else
        {
            Console.WriteLine("No handler was able to process the ticket.");
        }
    }

    protected abstract bool CanHandle(SupportTicket ticket);
    protected abstract void Process(SupportTicket ticket);
}

public class BasicSupportHandler : SupportHandler
{
    protected override bool CanHandle(SupportTicket ticket)
    {
        return ticket.Severity == 1;
    }

    protected override void Process(SupportTicket ticket)
    {
        Console.WriteLine($"Basic Support handled the issue: {ticket.Issue}");
    }
}

public class TechnicalSupportHandler : SupportHandler
{
    protected override bool CanHandle(SupportTicket ticket)
    {
        return ticket.Severity == 2;
    }

    protected override void Process(SupportTicket ticket)
    {
        Console.WriteLine($"Technical Support handled the issue: {ticket.Issue}");
    }
}

public class ProductSupportHandler : SupportHandler
{
    protected override bool CanHandle(SupportTicket ticket)
    {
        return ticket.Severity == 5;
    }

    protected override void Process(SupportTicket ticket)
    {
        Console.WriteLine($"Manager handled the issue: {ticket.Issue}");
    }
}

public class ManagerSupportHandler : SupportHandler
{
    protected override bool CanHandle(SupportTicket ticket)
    {
        return ticket.Severity == 3;
    }

    protected override void Process(SupportTicket ticket)
    {
        Console.WriteLine($"Manager handled the issue: {ticket.Issue}");
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        var basicSupport = new BasicSupportHandler();
        var technicalSupport = new TechnicalSupportHandler();
        var managerSupport = new ManagerSupportHandler();
        var productSupport = new ProductSupportHandler();

        basicSupport.SetNext(technicalSupport);
        technicalSupport.SetNext(productSupport);
        productSupport.SetNext(managerSupport);

        var tickets = new[]
        {
            new SupportTicket("Password reset request", 1),
            new SupportTicket("System crash during operation", 2),
            new SupportTicket("Budget approval for software purchase", 3),
            new SupportTicket("Unknown severe issue", 4)
        };

        foreach (var ticket in tickets)
        {
            Console.WriteLine($"\nProcessing ticket: {ticket.Issue}");
            basicSupport.Handle(ticket);
        }
    }
}
