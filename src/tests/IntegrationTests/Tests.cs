namespace Apify.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static ApifyClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("APIFY_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("APIFY_API_KEY environment variable is not found.");

        var client = new ApifyClient(apiKey);
        
        return client;
    }
}
