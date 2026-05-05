#nullable enable

namespace Apify
{
    public partial interface IDefaultRequestQueueClient
    {
        /// <summary>
        /// Unlock requests in default request queue<br/>
        /// Unlocks requests in the default request queue of the Actor run that are currently locked by the client.<br/>
        /// This endpoint is a shortcut for getting the run's `defaultRequestQueueId` and then using the<br/>
        /// [Unlock requests](/api/v2/request-queue-requests-unlock-post) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.UnlockRequestsResponse> ActorRunRequestQueueRequestsUnlockPostAsync(
            string runId,
            string? clientKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unlock requests in default request queue<br/>
        /// Unlocks requests in the default request queue of the Actor run that are currently locked by the client.<br/>
        /// This endpoint is a shortcut for getting the run's `defaultRequestQueueId` and then using the<br/>
        /// [Unlock requests](/api/v2/request-queue-requests-unlock-post) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.UnlockRequestsResponse>> ActorRunRequestQueueRequestsUnlockPostAsResponseAsync(
            string runId,
            string? clientKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}