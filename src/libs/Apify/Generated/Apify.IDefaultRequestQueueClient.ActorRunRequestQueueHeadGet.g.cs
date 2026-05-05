#nullable enable

namespace Apify
{
    public partial interface IDefaultRequestQueueClient
    {
        /// <summary>
        /// Get default request queue head<br/>
        /// Returns the given number of first requests from the default request queue of the Actor run.<br/>
        /// This endpoint is a shortcut for getting the run's `defaultRequestQueueId` and then using the<br/>
        /// [Get head](/api/v2/request-queue-head-get) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="limit">
        /// Example: 100
        /// </param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.HeadResponse> ActorRunRequestQueueHeadGetAsync(
            string runId,
            double? limit = default,
            string? clientKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get default request queue head<br/>
        /// Returns the given number of first requests from the default request queue of the Actor run.<br/>
        /// This endpoint is a shortcut for getting the run's `defaultRequestQueueId` and then using the<br/>
        /// [Get head](/api/v2/request-queue-head-get) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="limit">
        /// Example: 100
        /// </param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.HeadResponse>> ActorRunRequestQueueHeadGetAsResponseAsync(
            string runId,
            double? limit = default,
            string? clientKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}