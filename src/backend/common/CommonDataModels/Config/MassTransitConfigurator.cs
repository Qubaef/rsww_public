using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Shared.Config;

public static class MassTransitConfigurator
{

    public static void ConfigureMassTransit(this IServiceCollection services)
    {
        services.AddMassTransit(bus =>
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

    }
}
