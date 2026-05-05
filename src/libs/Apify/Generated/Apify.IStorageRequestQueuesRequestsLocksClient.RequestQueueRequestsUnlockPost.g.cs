#nullable enable

namespace Apify
{
    public partial interface IStorageRequestQueuesRequestsLocksClient
    {
        /// <summary>
        /// Unlock requests<br/>
        /// Unlocks requests in the queue that are currently locked by the client.<br/>
        /// * If the client is within an Actor run, it unlocks all requests locked by that specific run plus all requests locked by the same clientKey.<br/>
        /// * If the client is outside of an Actor run, it unlocks all requests locked using the same clientKey.
        /// </summary>
        /// <param name="queueId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.UnlockRequestsResponse> RequestQueueRequestsUnlockPostAsync(
            string queueId,
            string? clientKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unlock requests<br/>
        /// Unlocks requests in the queue that are currently locked by the client.<br/>
        /// * If the client is within an Actor run, it unlocks all requests locked by that specific run plus all requests locked by the same clientKey.<br/>
        /// * If the client is outside of an Actor run, it unlocks all requests locked using the same clientKey.
        /// </summary>
        /// <param name="queueId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.UnlockRequestsResponse>> RequestQueueRequestsUnlockPostAsResponseAsync(
            string queueId,
            string? clientKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}