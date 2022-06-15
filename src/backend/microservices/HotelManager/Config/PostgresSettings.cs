namespace HotelManager.Config;

public static class PostgresSettings
{
    private const string _env_var_name = "POSTGRESQL_CONNECTION_STRING";

    public static string ConnectionString
    {
        get
        {
            string? connectionString = Environment.GetEnvironmentVariable(_env_var_name);

            if (connectionString == null)
            {
                Console.WriteLine($"{_env_var_name} is not set! Connection String will be empty.");
                return String.Empty;
            }
            return connectionString;
        }
    }
}
