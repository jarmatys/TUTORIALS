namespace DI_Lifecycle.Interfaces;

public interface INotificationService
{
    Guid InstanceId { get; }
    
    string Send(string message);
}
