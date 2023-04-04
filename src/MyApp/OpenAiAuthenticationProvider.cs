using Microsoft.Kiota.Abstractions.Authentication;

namespace MyApp.OpenAi;

public sealed class OpenAiAuthenticationProvider : ApiKeyAuthenticationProvider
{
    public OpenAiAuthenticationProvider(string apiKey)
        : base("Bearer " + apiKey, "Authorization", KeyLocation.Header)
    {
    }
}