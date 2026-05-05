#nullable enable

namespace Apify
{
    public partial interface ILastActorTaskRunSDefaultRequestQueueClient
    {
        /// <summary>
        /// Update request in last task run's default request queue<br/>
        /// Updates a request in the default request queue of the last Actor task run.<br/>
        /// This endpoint is a shortcut for getting the last task run's `defaultRequestQueueId` and then using the<br/>
        /// [Update request](/api/v2/request-queue-request-put) endpoint.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="requestId">
        /// Example: xpsmkDlspokDSmklS
        /// </param>
        /// <param name="forefront">
        /// Example: false
        /// </param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.UpdateRequestResponse> ActorTaskRunsLastRequestQueueRequestPutAsync(
            string actorTaskId,
            string requestId,

            global::Apify.Request request,
            string? status = default,
            string? forefront = default,
            string? clientKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update request in last task run's default request queue<br/>
        /// Updates a request in the default request queue of the last Actor task run.<br/>
        /// This endpoint is a shortcut for getting the last task run's `defaultRequestQueueId` and then using the<br/>
        /// [Update request](/api/v2/request-queue-request-put) endpoint.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="requestId">
        /// Example: xpsmkDlspokDSmklS
        /// </param>
        /// <param name="forefront">
        /// Example: false
        /// </param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.UpdateRequestResponse>> ActorTaskRunsLastRequestQueueRequestPutAsResponseAsync(
            string actorTaskId,
            string requestId,

            global::Apify.Request request,
            string? status = default,
            string? forefront = default,
            string? clientKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update request in last task run's default request queue<br/>
        /// Updates a request in the default request queue of the last Actor task run.<br/>
        /// This endpoint is a shortcut for getting the last task run's `defaultRequestQueueId` and then using the<br/>
        /// [Update request](/api/v2/request-queue-request-put) endpoint.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="requestId">
        /// Example: xpsmkDlspokDSmklS
        /// </param>
        /// <param name="forefront">
        /// Example: false
        /// </param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.UpdateRequestResponse> ActorTaskRunsLastRequestQueueRequestPutAsync(
            string actorTaskId,
            string requestId,
            string? status = default,
            string? forefront = default,
            string? clientKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}