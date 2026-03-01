namespace DI_Lifecycle.Services;

using Interfaces;

public class NotificationService : INotificationService
{
    public Guid InstanceId { get; } = Guid.NewGuid();

    public string Send(string message) => $"[Notification {InstanceId}] {message}";
}
