#nullable enable

namespace Apify
{
    public partial interface IStorageRequestQueuesRequestsClient
    {
        /// <summary>
        /// Update request<br/>
        /// Updates a request in a queue. Mark request as handled by setting<br/>
        /// `request.handledAt = new Date()`.<br/>
        /// If `handledAt` is set, the request will be removed from head of the queue (and unlocked, if applicable).
        /// </summary>
        /// <param name="queueId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="requestId">
        /// Example: xpsmkDlspokDSmklS
        /// </param>
        /// <param name="forefront">
        /// Example: false
        /// </param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.UpdateRequestResponse> RequestQueueRequestPutAsync(
            string queueId,
            string requestId,

            global::Apify.Request request,
            string? forefront = default,
            string? clientKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update request<br/>
        /// Updates a request in a queue. Mark request as handled by setting<br/>
        /// `request.handledAt = new Date()`.<br/>
        /// If `handledAt` is set, the request will be removed from head of the queue (and unlocked, if applicable).
        /// </summary>
        /// <param name="queueId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="requestId">
        /// Example: xpsmkDlspokDSmklS
        /// </param>
        /// <param name="forefront">
        /// Example: false
        /// </param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.UpdateRequestResponse> RequestQueueRequestPutAsync(
            string queueId,
            string requestId,
            string? forefront = default,
            string? clientKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}