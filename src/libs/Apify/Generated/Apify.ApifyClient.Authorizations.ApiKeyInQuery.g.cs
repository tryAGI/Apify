
#nullable enable

namespace Apify
{
    public sealed partial class ApifyClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInQuery(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::Apify.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Query",
                Name = "token",
                Value = apiKey,
            });
        }
    }
}