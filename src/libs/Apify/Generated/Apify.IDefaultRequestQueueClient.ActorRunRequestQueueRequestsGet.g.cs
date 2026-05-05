#nullable enable

namespace Apify
{
    public partial interface IDefaultRequestQueueClient
    {
        /// <summary>
        /// List default request queue's requests<br/>
        /// Returns a list of requests from the default request queue of the Actor run.<br/>
        /// This endpoint is a shortcut for getting the run's `defaultRequestQueueId` and then using the<br/>
        /// [List requests](/api/v2/request-queue-requests-get) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
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
        global::System.Threading.Tasks.Task<global::Apify.ListOfRequestsResponse> ActorRunRequestQueueRequestsGetAsync(
            string runId,
            string? clientKey = default,
            string? exclusiveStartId = default,
            double? limit = default,
            string? cursor = default,
            global::System.Collections.Generic.IList<global::Apify.ActorRunRequestQueueRequestsGetFilterItem>? filter = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List default request queue's requests<br/>
        /// Returns a list of requests from the default request queue of the Actor run.<br/>
        /// This endpoint is a shortcut for getting the run's `defaultRequestQueueId` and then using the<br/>
        /// [List requests](/api/v2/request-queue-requests-get) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
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
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ListOfRequestsResponse>> ActorRunRequestQueueRequestsGetAsResponseAsync(
            string runId,
            string? clientKey = default,
            string? exclusiveStartId = default,
            double? limit = default,
            string? cursor = default,
            global::System.Collections.Generic.IList<global::Apify.ActorRunRequestQueueRequestsGetFilterItem>? filter = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}