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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.WebhookDispatchList> WebhookWebhookDispatchesGetAsync(
            string webhookId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}