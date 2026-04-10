#nullable enable

namespace Apify
{
    public partial interface IStorageRequestQueuesClient
    {
        /// <summary>
        /// Get request queue<br/>
        /// Returns queue object for given queue ID.
        /// </summary>
        /// <param name="queueId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.RequestQueueResponse> RequestQueueGetAsync(
            string queueId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}