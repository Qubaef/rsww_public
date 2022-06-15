using MassTransit;
using PaymentManager.Services;
using Shared.Config;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<PaymentService>();

// Configure MassTransit and add all consumers in this assembly
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

    bus.AddConsumers(Assembly.GetExecutingAssembly());
});

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
