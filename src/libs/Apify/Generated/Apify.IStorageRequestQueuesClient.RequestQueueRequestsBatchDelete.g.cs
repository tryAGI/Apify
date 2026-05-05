#nullable enable

namespace Apify
{
    public partial interface IStorageRequestQueuesClient
    {
        /// <summary>
        /// Delete requests<br/>
        /// Batch-deletes given requests from the queue. The number of requests in a<br/>
        /// batch is limited to 25. The response contains an array of unprocessed and<br/>
        /// processed requests.<br/>
        /// If any delete operation fails because the request queue rate limit is<br/>
        /// exceeded or an internal failure occurs,<br/>
        /// the failed request is returned in the `unprocessedRequests` response<br/>
        /// parameter.<br/>
        /// You can re-send these delete requests. It is recommended to use an<br/>
        /// exponential backoff algorithm for these retries.<br/>
        /// Each request is identified by its ID or uniqueKey parameter. You can use<br/>
        /// either of them to identify the request.
        /// </summary>
        /// <param name="queueId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="contentType"></param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.BatchDeleteResponse> RequestQueueRequestsBatchDeleteAsync(
            string queueId,

            global::System.Collections.Generic.IList<global::Apify.RequestDraftDelete> request,
            string contentType = "application/json",
            string? clientKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete requests<br/>
        /// Batch-deletes given requests from the queue. The number of requests in a<br/>
        /// batch is limited to 25. The response contains an array of unprocessed and<br/>
        /// processed requests.<br/>
        /// If any delete operation fails because the request queue rate limit is<br/>
        /// exceeded or an internal failure occurs,<br/>
        /// the failed request is returned in the `unprocessedRequests` response<br/>
        /// parameter.<br/>
        /// You can re-send these delete requests. It is recommended to use an<br/>
        /// exponential backoff algorithm for these retries.<br/>
        /// Each request is identified by its ID or uniqueKey parameter. You can use<br/>
        /// either of them to identify the request.
        /// </summary>
        /// <param name="queueId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="contentType"></param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.BatchDeleteResponse>> RequestQueueRequestsBatchDeleteAsResponseAsync(
            string queueId,

            global::System.Collections.Generic.IList<global::Apify.RequestDraftDelete> request,
            string contentType = "application/json",
            string? clientKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}