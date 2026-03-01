namespace DI_Lifecycle.Interfaces;

public interface IOrderService
{
    Guid InstanceId { get; }
    Guid NotificationInstanceId { get; }
    Guid PaymentInstanceId { get; }
    
    string AddToCart(string product);
    string Checkout();
}
