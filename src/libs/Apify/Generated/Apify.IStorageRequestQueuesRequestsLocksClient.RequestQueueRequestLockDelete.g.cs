#nullable enable

namespace Apify
{
    public partial interface IStorageRequestQueuesRequestsLocksClient
    {
        /// <summary>
        /// Delete request lock<br/>
        /// Deletes a request lock. The request lock can be deleted only by the client<br/>
        /// that has locked it using [Get and lock head<br/>
        /// operation](#/reference/request-queues/queue-head-with-locks).
        /// </summary>
        /// <param name="queueId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="requestId">
        /// Example: xpsmkDlspokDSmklS
        /// </param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="forefront">
        /// Example: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task RequestQueueRequestLockDeleteAsync(
            string queueId,
            string requestId,
            string? clientKey = default,
            string? forefront = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}