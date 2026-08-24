#nullable enable

namespace Apify
{
    public partial interface ILastActorRunSDefaultRequestQueueClient
    {
        /// <summary>
        /// Batch add requests to last run's default request queue<br/>
        /// Adds requests to the default request queue of the last Actor run in batch.<br/>
        /// This endpoint is a shortcut for getting the last run's `defaultRequestQueueId` and then using the<br/>
        /// [Add requests](/api/v2/request-queue-requests-batch-post) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="forefront">
        /// Example: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.BatchAddResponse> ActorRunsLastRequestQueueRequestsBatchPostAsync(
            string actorId,

            global::System.Collections.Generic.IList<global::Apify.RequestWithoutId> request,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            string? clientKey = default,
            string? forefront = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch add requests to last run's default request queue<br/>
        /// Adds requests to the default request queue of the last Actor run in batch.<br/>
        /// This endpoint is a shortcut for getting the last run's `defaultRequestQueueId` and then using the<br/>
        /// [Add requests](/api/v2/request-queue-requests-batch-post) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="forefront">
        /// Example: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.BatchAddResponse>> ActorRunsLastRequestQueueRequestsBatchPostAsResponseAsync(
            string actorId,

            global::System.Collections.Generic.IList<global::Apify.RequestWithoutId> request,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            string? clientKey = default,
            string? forefront = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}