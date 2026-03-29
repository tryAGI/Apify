#nullable enable

namespace Apify
{
    public partial interface IWebhooksWebhookDispatchesClient
    {
        /// <summary>
        /// Get webhook dispatch<br/>
        /// Gets webhook dispatch object with all details.
        /// </summary>
        /// <param name="dispatchId">
        /// Example: Zib4xbZsmvZeK55ua
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.WebhookDispatchResponse> WebhookDispatchGetAsync(
            string dispatchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}