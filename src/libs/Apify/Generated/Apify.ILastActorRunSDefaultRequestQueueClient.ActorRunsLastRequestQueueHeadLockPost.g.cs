#nullable enable

namespace Apify
{
    public partial interface ILastActorRunSDefaultRequestQueueClient
    {
        /// <summary>
        /// Get and lock last run's default request queue head<br/>
        /// Returns the given number of first requests from the default request queue of the last Actor run<br/>
        /// and locks them for the given time.<br/>
        /// This endpoint is a shortcut for getting the last run's `defaultRequestQueueId` and then using the<br/>
        /// [Get head and lock](/api/v2/request-queue-head-lock-post) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
        /// <param name="lockSecs">
        /// Example: 60
        /// </param>
        /// <param name="limit">
        /// Example: 25
        /// </param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.HeadAndLockResponse> ActorRunsLastRequestQueueHeadLockPostAsync(
            string actorId,
            double lockSecs,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            double? limit = default,
            string? clientKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get and lock last run's default request queue head<br/>
        /// Returns the given number of first requests from the default request queue of the last Actor run<br/>
        /// and locks them for the given time.<br/>
        /// This endpoint is a shortcut for getting the last run's `defaultRequestQueueId` and then using the<br/>
        /// [Get head and lock](/api/v2/request-queue-head-lock-post) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
        /// <param name="lockSecs">
        /// Example: 60
        /// </param>
        /// <param name="limit">
        /// Example: 25
        /// </param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.HeadAndLockResponse>> ActorRunsLastRequestQueueHeadLockPostAsResponseAsync(
            string actorId,
            double lockSecs,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            double? limit = default,
            string? clientKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}