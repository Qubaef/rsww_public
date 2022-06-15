namespace Shared.Config;

public static class MongoDbSettings
{
    private const string _connectionStringEnvVar = "MONGODB_CONNECTION_STRING";
    private const string _databaseEnvVar = "MONGODB_DATABASE";
    private const string _collectionNameEnvVar = "MONGODB_COLLECTION";
    private const string _eventcollectionNameEnvVar = "MONGODB_EVENT_COLLECTION";
    public static string ConnectionString
    {
        get { return EnvironmentSettings.GetVariable(_connectionStringEnvVar); }
    }
    public static string Database
    {
        get { return EnvironmentSettings.GetVariable(_databaseEnvVar); }
    }
    public static string Collection
    {
        get { return EnvironmentSettings.GetVariable(_collectionNameEnvVar); }
    }

    public static string EventCollection
    {
        get { return EnvironmentSettings.GetVariable(_eventcollectionNameEnvVar); }
    }    


}

