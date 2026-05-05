#nullable enable

namespace Apify
{
    public partial interface ILastActorTaskRunSDefaultRequestQueueClient
    {
        /// <summary>
        /// Get last task run's default request queue<br/>
        /// Returns the default request queue associated with the last Actor task run.<br/>
        /// This endpoint is a shortcut for getting the last task run's `defaultRequestQueueId` and then using the<br/>
        /// [Get request queue](/api/v2/request-queue-get) endpoint.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.RequestQueueResponse> ActorTaskRunsLastRequestQueueGetAsync(
            string actorTaskId,
            string? status = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get last task run's default request queue<br/>
        /// Returns the default request queue associated with the last Actor task run.<br/>
        /// This endpoint is a shortcut for getting the last task run's `defaultRequestQueueId` and then using the<br/>
        /// [Get request queue](/api/v2/request-queue-get) endpoint.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.RequestQueueResponse>> ActorTaskRunsLastRequestQueueGetAsResponseAsync(
            string actorTaskId,
            string? status = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}