#nullable enable

namespace Apify
{
    public partial interface ILastActorTaskRunSDefaultRequestQueueClient
    {
        /// <summary>
        /// Batch delete requests from last task run's default request queue<br/>
        /// Batch-deletes requests from the default request queue of the last Actor task run.<br/>
        /// This endpoint is a shortcut for getting the last task run's `defaultRequestQueueId` and then using the<br/>
        /// [Delete requests](/api/v2/request-queue-requests-batch-delete) endpoint.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="contentType"></param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.BatchDeleteResponse> ActorTaskRunsLastRequestQueueRequestsBatchDeleteAsync(
            string actorTaskId,

            global::System.Collections.Generic.IList<global::Apify.RequestDraftDelete> request,
            string? status = default,
            string contentType = "application/json",
            string? clientKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch delete requests from last task run's default request queue<br/>
        /// Batch-deletes requests from the default request queue of the last Actor task run.<br/>
        /// This endpoint is a shortcut for getting the last task run's `defaultRequestQueueId` and then using the<br/>
        /// [Delete requests](/api/v2/request-queue-requests-batch-delete) endpoint.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="contentType"></param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.BatchDeleteResponse>> ActorTaskRunsLastRequestQueueRequestsBatchDeleteAsResponseAsync(
            string actorTaskId,

            global::System.Collections.Generic.IList<global::Apify.RequestDraftDelete> request,
            string? status = default,
            string contentType = "application/json",
            string? clientKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}