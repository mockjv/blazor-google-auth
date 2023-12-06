# Blazor Google Auth

Quick test application based on
a <a href="https://learn.microsoft.com/en-us/answers/questions/830958/how-to-implement-google-authetication-in-blazor-se">
question posted to Microsoft Learn</a> for setting up Google Authentication in Blazor.

The differences include:

- Updated to .NET 8
- Cleanup of the logic to properly use `AuthenticationStateProvider` instead of `HttpContextAccessor`, since it's not
  valid to utilize `HttpContextAccessor` within a Blazor circuit (access is not guaranteed).