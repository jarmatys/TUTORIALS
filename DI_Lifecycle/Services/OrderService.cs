namespace DI_Lifecycle.Services;

using Interfaces;

public class OrderService(INotificationService notificationService, IPaymentService paymentService) : IOrderService
{
    private readonly List<string> _cart = [];

    public Guid InstanceId { get; } = Guid.NewGuid();
    public Guid NotificationInstanceId => notificationService.InstanceId;
    public Guid PaymentInstanceId => paymentService.InstanceId;

    public string AddToCart(string product)
    {
        _cart.Add(product);

        notificationService.Send($"Product '{product}' added to cart");

        return $"[Order {InstanceId}] Added '{product}' to cart. Items: {_cart.Count}";
    }

    public string Checkout()
    {
        var items = string.Join(", ", _cart);
        var total = _cart.Count * 999.99m;

        paymentService.ProcessPayment(total);
        notificationService.Send($"Order completed with: {items}");

        return $"[Order {InstanceId}] Checkout completed. Items: {items}";
    }
}
