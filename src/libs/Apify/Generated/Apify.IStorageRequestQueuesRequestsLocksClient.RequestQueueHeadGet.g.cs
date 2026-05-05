#nullable enable

namespace Apify
{
    public partial interface IStorageRequestQueuesRequestsLocksClient
    {
        /// <summary>
        /// Get head<br/>
        /// Returns given number of first requests from the queue.<br/>
        /// The response contains the `hadMultipleClients` boolean field which indicates<br/>
        /// that the queue was accessed by more than one client (with unique or empty<br/>
        /// `clientKey`).<br/>
        /// This field is used by [Apify SDK](https://sdk.apify.com) to determine<br/>
        /// whether the local cache is consistent with the request queue, and thus<br/>
        /// optimize performance of certain operations.
        /// </summary>
        /// <param name="queueId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="limit">
        /// Example: 100
        /// </param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.HeadResponse> RequestQueueHeadGetAsync(
            string queueId,
            double? limit = default,
            string? clientKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get head<br/>
        /// Returns given number of first requests from the queue.<br/>
        /// The response contains the `hadMultipleClients` boolean field which indicates<br/>
        /// that the queue was accessed by more than one client (with unique or empty<br/>
        /// `clientKey`).<br/>
        /// This field is used by [Apify SDK](https://sdk.apify.com) to determine<br/>
        /// whether the local cache is consistent with the request queue, and thus<br/>
        /// optimize performance of certain operations.
        /// </summary>
        /// <param name="queueId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="limit">
        /// Example: 100
        /// </param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.HeadResponse>> RequestQueueHeadGetAsResponseAsync(
            string queueId,
            double? limit = default,
            string? clientKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}