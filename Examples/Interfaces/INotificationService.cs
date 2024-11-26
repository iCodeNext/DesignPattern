namespace Examples.Interfaces;

public interface INotificationService
{
    Task NotifyAsync(string message);
}