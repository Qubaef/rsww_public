using HotelManager;
using HotelManager.Config;
using HotelManager.Consumers;
using HotelManager.Services;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using Shared.Config;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
    bus.AddConsumers(typeof(HotelReservationConsumer), typeof(HotelReservationConsumerDefinition));
    bus.AddConsumers(typeof(HotelRequestConsumer));
    bus.AddConsumers(typeof(HotelUpdateConsumer), typeof(HotelUpdateConsumerDefinition));
});

builder.Services.AddDbContext<HotelContext>(options =>
    options.UseNpgsql(PostgresSettings.ConnectionString)
);
builder.Services.AddSingleton<MongoHotelContext>();
builder.Services.AddScoped<HotelServices>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<HotelContext>();
    context.Database.EnsureCreated();
    DbInit.CreateSampleData(context);
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
