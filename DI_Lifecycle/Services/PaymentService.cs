namespace DI_Lifecycle.Services;

using Interfaces;

public class PaymentService : IPaymentService
{
    public Guid InstanceId { get; } = Guid.NewGuid();

    public string ProcessPayment(decimal amount) => $"[Payment {InstanceId}] Processing payment: {amount:C}";
}
