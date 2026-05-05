#nullable enable

namespace Apify
{
    public partial interface IDefaultRequestQueueClient
    {
        /// <summary>
        /// Batch delete requests from default request queue<br/>
        /// Batch-deletes requests from the default request queue of the Actor run.<br/>
        /// This endpoint is a shortcut for getting the run's `defaultRequestQueueId` and then using the<br/>
        /// [Delete requests](/api/v2/request-queue-requests-batch-delete) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="contentType"></param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.BatchDeleteResponse> ActorRunRequestQueueRequestsBatchDeleteAsync(
            string runId,

            global::System.Collections.Generic.IList<global::Apify.RequestDraftDelete> request,
            string contentType = "application/json",
            string? clientKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch delete requests from default request queue<br/>
        /// Batch-deletes requests from the default request queue of the Actor run.<br/>
        /// This endpoint is a shortcut for getting the run's `defaultRequestQueueId` and then using the<br/>
        /// [Delete requests](/api/v2/request-queue-requests-batch-delete) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="contentType"></param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.BatchDeleteResponse>> ActorRunRequestQueueRequestsBatchDeleteAsResponseAsync(
            string runId,

            global::System.Collections.Generic.IList<global::Apify.RequestDraftDelete> request,
            string contentType = "application/json",
            string? clientKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}