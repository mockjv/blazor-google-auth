namespace BlazorGoogleAuth;

public static class ConfigurationExtensions
{
    public static T GetExpectedValue<T>(this IConfiguration configuration, string key)
    {
        return configuration.GetValue<T>(key) ?? throw new ConfigurationException(key);
    }
}