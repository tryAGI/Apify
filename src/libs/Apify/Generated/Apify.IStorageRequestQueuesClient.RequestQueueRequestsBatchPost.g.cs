#nullable enable

namespace Apify
{
    public partial interface IStorageRequestQueuesClient
    {
        /// <summary>
        /// Add requests<br/>
        /// Adds requests to the queue in batch. The maximum requests in batch is limit<br/>
        /// to 25. The response contains an array of unprocessed and processed requests.<br/>
        /// If any add operation fails because the request queue rate limit is exceeded<br/>
        /// or an internal failure occurs,<br/>
        /// the failed request is returned in the unprocessedRequests response<br/>
        /// parameter.<br/>
        /// You can resend these requests to add. It is recommended to use exponential<br/>
        /// backoff algorithm for these retries.<br/>
        /// If a request with the same `uniqueKey` was already present in the queue,<br/>
        /// then it returns an ID of the existing request.
        /// </summary>
        /// <param name="queueId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="forefront">
        /// Example: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.BatchAddResponse> RequestQueueRequestsBatchPostAsync(
            string queueId,

            global::System.Collections.Generic.IList<global::Apify.RequestBase> request,
            string? clientKey = default,
            string? forefront = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}