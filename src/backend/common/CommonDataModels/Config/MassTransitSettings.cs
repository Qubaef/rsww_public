namespace Shared.Config;

public static class MassTransitSettings
{
    private const string _hostEnvVar = "RABBITMQ_HOST";
    private const string _virtualHostEnvVar = "RABBITMQ_VIRTUAL_HOST";
    private const string _userEnvVar = "RABBITMQ_USER";
    private const string _passwordEnvVar = "RABBITMQ_PASSWORD";
    public static string Host
    {
        get { return EnvironmentSettings.GetVariable(_hostEnvVar); }
    }

    public static string VirtualHost
    {
        get { return EnvironmentSettings.GetVariable(_virtualHostEnvVar); }
    }

    public static string User
    {
        get { return EnvironmentSettings.GetVariable(_userEnvVar); }
    }

    public static string Password
    {
        get { return EnvironmentSettings.GetVariable(_passwordEnvVar); }
    }

}
