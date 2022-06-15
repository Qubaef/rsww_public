using HotelManager.Consumers;
using MassTransit;
using Shared.Config;
using TransportManager;
using TransportManager.Consumers;
using TransportManager.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMassTransit(bus =>
{
    bus.UsingRabbitMq((context, config) =>
    {
        config.Host(MassTransitSettings.Host, MassTransitSettings.VirtualHost, hostConfig =>
        {
            hostConfig.Username(MassTransitSettings.User);
            hostConfig.Password(MassTransitSettings.Password);
        });

        config.ConfigureEndpoints(context);
    });

    // bus.AddConsumers(Assembly.GetExecutingAssembly());
    bus.AddConsumers(typeof(TransportReservationConsumer), typeof(TransportReservationConsumerDefinition));
    bus.AddConsumers(typeof(TransportRequestConsumer));
});

builder.Services.AddSingleton<TransportContext>();

builder.Services.AddScoped<TransportService>();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<TransportContext>();
    InitTrans.CreateSampleData(context);
}

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
