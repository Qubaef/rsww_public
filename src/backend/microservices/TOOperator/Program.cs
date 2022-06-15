using MassTransit;
using Shared.Config;
using System.Reflection;
using TOOperator.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMassTransit(bus =>
{
    bus.AddConsumers(Assembly.GetExecutingAssembly());

    bus.UsingRabbitMq((context, config) =>
    {
        config.Host(MassTransitSettings.Host, MassTransitSettings.VirtualHost, hostConfig =>
        {
            hostConfig.Username(MassTransitSettings.User);
            hostConfig.Password(MassTransitSettings.Password);
        });

        config.ConfigureEndpoints(context);
    });

});

builder.Services.AddSingleton<ResourceChangeGenerator>();

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
