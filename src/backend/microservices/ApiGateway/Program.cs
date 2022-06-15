using ApiGateway.Config;
using ApiGateway.Services;
using MassTransit;
using Microsoft.AspNetCore.Authentication.Cookies;
using Shared.Config;
using System.Reflection;
using ApiGateway.SignalR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Default authentication with redirect
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/user/login";
        options.Events.OnRedirectToAccessDenied =
            options.Events.OnRedirectToLogin = context =>
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                return Task.FromResult<object>(null);

            };
    });
builder.Services.AddSingleton<AuthService>();

// Configure MassTransit and add all consumers in this assembly
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

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.SetIsOriginAllowed(x => true)
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials();
    });
});

builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();
app.UseAuthentication();
app.UseAuthorization();

app.MapHub<SignalRMessenger>("/messenger").AllowAnonymous(); ;

app.MapControllers();
app.Run();
