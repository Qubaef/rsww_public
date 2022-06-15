using MassTransit;
using OrderManager;
using OrderManager.Services;
using Shared.Config;
using System.Reflection;
using Shared.Contracts.HotelManager;
using Shared.Contracts.OrderManager;
using Shared.Contracts.PaymentManager;
using Shared.Contracts.TransportManager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// builder.Services.AddScoped<OrderPerformer>();
builder.Services.AddSingleton<OrdersCollection>();

builder.Services.AddMassTransit(bus =>
{
    bus.AddConsumers(Assembly.GetExecutingAssembly());

    bus.AddDelayedMessageScheduler();
    
    bus.AddSagaStateMachine<BookStateMachine, BookState>(cfg =>
    {
        cfg.UseConcurrentMessageLimit(4);
        cfg.UseInMemoryOutbox();
        var partition = cfg.CreatePartitioner(4);

        cfg.Message<BookOrder>(s => s.UsePartitioner(partition, m => m.Message.Guid));
        cfg.Message<ReserveTransportSuccess>(s => s.UsePartitioner(partition, m => m.Message.Guid));
        cfg.Message<ReserveTransportFailure>(s => s.UsePartitioner(partition, m => m.Message.Guid));
        cfg.Message<ReserveHotelSuccess>(s => s.UsePartitioner(partition, m => m.Message.Guid));
        cfg.Message<ReserveHotelFailure>(s => s.UsePartitioner(partition, m => m.Message.Guid));
        cfg.Message<PurchaseOrder>(s => s.UsePartitioner(partition, m => m.Message.Guid));
        cfg.Message<OrderExpired>(s => s.UsePartitioner(partition, m => m.Message.Guid));
        cfg.Message<PaymentSuccess>(s => s.UsePartitioner(partition, m => m.Message.Guid));
        cfg.Message<PaymentFailure>(s => s.UsePartitioner(partition, m => m.Message.Guid));

    }).MongoDbRepository(c =>
    {
        c.Connection = MongoDbSettings.ConnectionString;
        c.DatabaseName = MongoDbSettings.Database;
        c.CollectionName = "OrderSaga";
    });

    bus.UsingRabbitMq((context, config) =>
    {
        config.UseDelayedMessageScheduler();
        config.Host(MassTransitSettings.Host, MassTransitSettings.VirtualHost, hostConfig =>
        {
            hostConfig.Username(MassTransitSettings.User);
            hostConfig.Password(MassTransitSettings.Password);
        });

        config.ConfigureEndpoints(context);
    });

    
}).Configure<MassTransitHostOptions>(x =>
{
    x.WaitUntilStarted = true;
});
builder.Services.AddSingleton<OrderContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
