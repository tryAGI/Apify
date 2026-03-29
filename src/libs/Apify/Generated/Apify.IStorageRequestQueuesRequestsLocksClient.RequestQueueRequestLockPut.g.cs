#nullable enable

namespace Apify
{
    public partial interface IStorageRequestQueuesRequestsLocksClient
    {
        /// <summary>
        /// Prolong request lock<br/>
        /// Prolongs request lock. The request lock can be prolonged only by the client<br/>
        /// that has locked it using [Get and lock head<br/>
        /// operation](#/reference/request-queues/queue-head-with-locks).
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ProlongRequestLockResponse> RequestQueueRequestLockPutAsync(
            string queueId,
            string requestId,
            double lockSecs,
            string? clientKey = default,
            string? forefront = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}