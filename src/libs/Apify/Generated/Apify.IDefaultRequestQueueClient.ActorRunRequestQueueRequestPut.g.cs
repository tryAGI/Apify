#nullable enable

namespace Apify
{
    public partial interface IDefaultRequestQueueClient
    {
        /// <summary>
        /// Update request in default request queue<br/>
        /// Updates a request in the default request queue of the Actor run.<br/>
        /// This endpoint is a shortcut for getting the run's `defaultRequestQueueId` and then using the<br/>
        /// [Update request](/api/v2/request-queue-request-put) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
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
        global::System.Threading.Tasks.Task<global::Apify.UpdateRequestResponse> ActorRunRequestQueueRequestPutAsync(
            string runId,
            string requestId,

            global::Apify.Request request,
            string? forefront = default,
            string? clientKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update request in default request queue<br/>
        /// Updates a request in the default request queue of the Actor run.<br/>
        /// This endpoint is a shortcut for getting the run's `defaultRequestQueueId` and then using the<br/>
        /// [Update request](/api/v2/request-queue-request-put) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
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
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.UpdateRequestResponse>> ActorRunRequestQueueRequestPutAsResponseAsync(
            string runId,
            string requestId,

            global::Apify.Request request,
            string? forefront = default,
            string? clientKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update request in default request queue<br/>
        /// Updates a request in the default request queue of the Actor run.<br/>
        /// This endpoint is a shortcut for getting the run's `defaultRequestQueueId` and then using the<br/>
        /// [Update request](/api/v2/request-queue-request-put) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
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
        global::System.Threading.Tasks.Task<global::Apify.UpdateRequestResponse> ActorRunRequestQueueRequestPutAsync(
            string runId,
            string requestId,
            string? forefront = default,
            string? clientKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}