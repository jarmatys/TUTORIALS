using DI_Lifecycle.Interfaces;
using DI_Lifecycle.Services;

var builder = WebApplication.CreateBuilder(args);

// Transient: nowa instancja przy kazdym wstrzyknieciu
builder.Services.AddTransient<IPaymentService, PaymentService>();

// Scoped: jedna instancja na caly HTTP request
builder.Services.AddScoped<IOrderService, OrderService>();

// Singleton: jedna instancja na caly czas zycia aplikacji
builder.Services.AddSingleton<INotificationService, NotificationService>();

var app = builder.Build();

app.MapPost("api/orders", (IOrderService orderService, IPaymentService paymentService) =>
{
    var addToCart1 = orderService.AddToCart("Laptop");
    var addToCart2 = orderService.AddToCart("Mouse");
    
    var checkout = orderService.Checkout();

    return Results.Ok(new
    {
        Scoped_OrderService = new
        {
            Step1 = addToCart1,
            Step2 = addToCart2,
            Step3 = checkout,
            InstanceId = orderService.InstanceId,
            Info = "Same instance within request - cart keeps state"
        },

        Transient_PaymentService = new
        {
            InstanceIdInOrder = orderService.PaymentInstanceId,
            InstanceIdInEndpoint = paymentService.InstanceId,
            AreSame = orderService.PaymentInstanceId == paymentService.InstanceId,
            Info = "Different instance each time it's resolved"
        },

        Singleton_NotificationService = new
        {
            InstanceId = orderService.NotificationInstanceId,
            Info = "Same instance for entire app lifetime"
        }
    });
});

app.Run();
