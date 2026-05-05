#nullable enable

namespace Apify
{
    public partial interface IWebhooksWebhooksClient
    {
        /// <summary>
        /// Get collection<br/>
        /// Gets a given webhook's list of dispatches.
        /// </summary>
        /// <param name="webhookId">
        /// Example: pVJtoTelgYUq4qJOt
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ListOfWebhookDispatchesResponse> WebhookWebhookDispatchesGetAsync(
            string webhookId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get collection<br/>
        /// Gets a given webhook's list of dispatches.
        /// </summary>
        /// <param name="webhookId">
        /// Example: pVJtoTelgYUq4qJOt
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ListOfWebhookDispatchesResponse>> WebhookWebhookDispatchesGetAsResponseAsync(
            string webhookId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}