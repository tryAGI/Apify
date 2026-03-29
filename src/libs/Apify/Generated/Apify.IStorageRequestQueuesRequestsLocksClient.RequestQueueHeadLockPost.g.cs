#nullable enable

namespace Apify
{
    public partial interface IStorageRequestQueuesRequestsLocksClient
    {
        /// <summary>
        /// Get head and lock<br/>
        /// Returns the given number of first requests from the queue and locks them for<br/>
        /// the given time.<br/>
        /// If this endpoint locks the request, no other client or run will be able to get and<br/>
        /// lock these requests.<br/>
        /// The response contains the `hadMultipleClients` boolean field which indicates<br/>
        /// that the queue was accessed by more than one client (with unique or empty<br/>
        /// `clientKey`).
        /// </summary>
        /// <param name="queueId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="lockSecs">
        /// Example: 60
        /// </param>
        /// <param name="limit">
        /// Example: 25
        /// </param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.HeadAndLockResponse> RequestQueueHeadLockPostAsync(
            string queueId,
            double lockSecs,
            double? limit = default,
            string? clientKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}