#nullable enable

namespace Apify
{
    public partial interface IStorageRequestQueuesRequestsClient
    {
        /// <summary>
        /// List requests<br/>
        /// Returns a list of requests. This endpoint is paginated using<br/>
        /// cursor (pagination by `exclusiveStartId` is deprecated) and limit parameters.
        /// </summary>
        /// <param name="queueId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="exclusiveStartId">
        /// Example: Ihnsp8YrvJ8102Kj
        /// </param>
        /// <param name="limit">
        /// Example: 100
        /// </param>
        /// <param name="cursor">
        /// Example: eyJyZXF1ZXN0SWQiOiI2OFRqQ2RaTDNvM2hiUU0ifQ
        /// </param>
        /// <param name="filter">
        /// Example: [locked]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ListOfRequestsResponse> RequestQueueRequestsGetAsync(
            string queueId,
            string? clientKey = default,
            string? exclusiveStartId = default,
            double? limit = default,
            string? cursor = default,
            global::System.Collections.Generic.IList<global::Apify.RequestQueueRequestsGetFilterItem>? filter = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List requests<br/>
        /// Returns a list of requests. This endpoint is paginated using<br/>
        /// cursor (pagination by `exclusiveStartId` is deprecated) and limit parameters.
        /// </summary>
        /// <param name="queueId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="exclusiveStartId">
        /// Example: Ihnsp8YrvJ8102Kj
        /// </param>
        /// <param name="limit">
        /// Example: 100
        /// </param>
        /// <param name="cursor">
        /// Example: eyJyZXF1ZXN0SWQiOiI2OFRqQ2RaTDNvM2hiUU0ifQ
        /// </param>
        /// <param name="filter">
        /// Example: [locked]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ListOfRequestsResponse>> RequestQueueRequestsGetAsResponseAsync(
            string queueId,
            string? clientKey = default,
            string? exclusiveStartId = default,
            double? limit = default,
            string? cursor = default,
            global::System.Collections.Generic.IList<global::Apify.RequestQueueRequestsGetFilterItem>? filter = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}