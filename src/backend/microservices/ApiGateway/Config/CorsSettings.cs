using Shared.Config;

namespace ApiGateway.Config;

public static class CorsSettings
{
    private const string _env_var_name = "CORS_ORIGINS";

    public static string[] CorsOrigins
    {
        get { return EnvironmentSettings.GetVariable(_env_var_name).Split(";"); }
    }
}