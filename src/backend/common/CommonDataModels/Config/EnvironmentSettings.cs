namespace Shared.Config;
public static class EnvironmentSettings
{
    public static string GetVariable(string envVarName)
    {
        string? variable = Environment.GetEnvironmentVariable(envVarName);
        if (variable == null)
        {
            throw new ArgumentNullException($"{envVarName} is not set!");
        }

        return variable;
    }
}