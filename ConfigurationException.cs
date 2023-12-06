namespace BlazorGoogleAuth;

public class ConfigurationException(string key)
    : Exception($"Expected configuration {key} is not properly specified");