#nullable enable

namespace Apify
{
    public partial interface IWebhooksWebhooksClient
    {
        /// <summary>
        /// Test webhook<br/>
        /// Tests a webhook. Creates a webhook dispatch with a dummy payload.
        /// </summary>
        /// <param name="webhookId">
        /// Example: pVJtoTelgYUq4qJOt
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.TestWebhookResponse> WebhookTestPostAsync(
            string webhookId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}