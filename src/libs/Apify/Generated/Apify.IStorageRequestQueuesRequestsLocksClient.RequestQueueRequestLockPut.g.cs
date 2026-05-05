#nullable enable

namespace Apify
{
    public partial interface IStorageRequestQueuesRequestsLocksClient
    {
        /// <summary>
        /// Prolong request lock<br/>
        /// Prolongs request lock. The request lock can be prolonged only by the client<br/>
        /// that has locked it using [Get and lock head<br/>
        /// operation](#/request-queue-head-lock-post).<br/>
        /// The clientKey identifier is used for locking and unlocking requests.<br/>
        /// You can delete or prolong the lock only for requests that were locked by the same client key or from the same Actor run.
        /// </summary>
        /// <param name="queueId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="requestId">
        /// Example: xpsmkDlspokDSmklS
        /// </param>
        /// <param name="lockSecs">
        /// Example: 60
        /// </param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="forefront">
        /// Example: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ProlongRequestLockResponse> RequestQueueRequestLockPutAsync(
            string queueId,
            string requestId,
            double lockSecs,
            string? clientKey = default,
            string? forefront = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Prolong request lock<br/>
        /// Prolongs request lock. The request lock can be prolonged only by the client<br/>
        /// that has locked it using [Get and lock head<br/>
        /// operation](#/request-queue-head-lock-post).<br/>
        /// The clientKey identifier is used for locking and unlocking requests.<br/>
        /// You can delete or prolong the lock only for requests that were locked by the same client key or from the same Actor run.
        /// </summary>
        /// <param name="queueId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="requestId">
        /// Example: xpsmkDlspokDSmklS
        /// </param>
        /// <param name="lockSecs">
        /// Example: 60
        /// </param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="forefront">
        /// Example: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ProlongRequestLockResponse>> RequestQueueRequestLockPutAsResponseAsync(
            string queueId,
            string requestId,
            double lockSecs,
            string? clientKey = default,
            string? forefront = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}