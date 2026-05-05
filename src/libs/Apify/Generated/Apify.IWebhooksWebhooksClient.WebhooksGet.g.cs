#nullable enable

namespace Apify
{
    public partial interface IWebhooksWebhooksClient
    {
        /// <summary>
        /// Get list of webhooks<br/>
        /// Gets the list of webhooks that the user created.<br/>
        /// The endpoint supports pagination using the `limit` and `offset` parameters<br/>
        /// and it will not return more than 1000 records.<br/>
        /// By default, the records are sorted by the `createdAt` field in ascending<br/>
        /// order. To sort the records in descending order, use the `desc=1`<br/>
        /// parameter.
        /// </summary>
        /// <param name="offset">
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Example: 1000
        /// </param>
        /// <param name="desc">
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ListOfWebhooksResponse> WebhooksGetAsync(
            double? offset = default,
            double? limit = default,
            bool? desc = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get list of webhooks<br/>
        /// Gets the list of webhooks that the user created.<br/>
        /// The endpoint supports pagination using the `limit` and `offset` parameters<br/>
        /// and it will not return more than 1000 records.<br/>
        /// By default, the records are sorted by the `createdAt` field in ascending<br/>
        /// order. To sort the records in descending order, use the `desc=1`<br/>
        /// parameter.
        /// </summary>
        /// <param name="offset">
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Example: 1000
        /// </param>
        /// <param name="desc">
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ListOfWebhooksResponse>> WebhooksGetAsResponseAsync(
            double? offset = default,
            double? limit = default,
            bool? desc = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}