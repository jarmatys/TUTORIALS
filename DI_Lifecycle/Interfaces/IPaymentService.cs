namespace DI_Lifecycle.Interfaces;

public interface IPaymentService
{
    Guid InstanceId { get; }
    
    string ProcessPayment(decimal amount);
}
