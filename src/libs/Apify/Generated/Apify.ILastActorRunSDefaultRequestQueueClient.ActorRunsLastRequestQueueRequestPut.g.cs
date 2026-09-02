#nullable enable

namespace Apify
{
    public partial interface ILastActorRunSDefaultRequestQueueClient
    {
        /// <summary>
        /// Update request in last run's default request queue<br/>
        /// Updates a request in the default request queue of the last Actor run.<br/>
        /// This endpoint is a shortcut for getting the last run's `defaultRequestQueueId` and then using the<br/>
        /// [Update request](/api/v2/request-queue-request-put) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
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
        global::System.Threading.Tasks.Task<global::Apify.UpdateRequestResponse> ActorRunsLastRequestQueueRequestPutAsync(
            string actorId,
            string requestId,

            global::Apify.RequestWithoutId request,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            string? forefront = default,
            string? clientKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update request in last run's default request queue<br/>
        /// Updates a request in the default request queue of the last Actor run.<br/>
        /// This endpoint is a shortcut for getting the last run's `defaultRequestQueueId` and then using the<br/>
        /// [Update request](/api/v2/request-queue-request-put) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
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
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.UpdateRequestResponse>> ActorRunsLastRequestQueueRequestPutAsResponseAsync(
            string actorId,
            string requestId,

            global::Apify.RequestWithoutId request,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            string? forefront = default,
            string? clientKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update request in last run's default request queue<br/>
        /// Updates a request in the default request queue of the last Actor run.<br/>
        /// This endpoint is a shortcut for getting the last run's `defaultRequestQueueId` and then using the<br/>
        /// [Update request](/api/v2/request-queue-request-put) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
        /// <param name="requestId">
        /// Example: xpsmkDlspokDSmklS
        /// </param>
        /// <param name="forefront">
        /// Example: false
        /// </param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="uniqueKey">
        /// A unique key used for request de-duplication. Requests with the same unique key are considered identical.
        /// </param>
        /// <param name="url">
        /// The URL of the request.
        /// </param>
        /// <param name="method">
        /// The HTTP method of the request.
        /// </param>
        /// <param name="retryCount">
        /// The number of times this request has been retried.
        /// </param>
        /// <param name="loadedUrl">
        /// The final URL that was loaded, after redirects (if any).
        /// </param>
        /// <param name="payload">
        /// The request payload, typically used with POST or PUT requests.
        /// </param>
        /// <param name="headers">
        /// HTTP headers sent with the request.
        /// </param>
        /// <param name="userData">
        /// Custom user data attached to the request. Can contain arbitrary fields.<br/>
        /// Example: {"label":"DETAIL","customField":"custom-value"}
        /// </param>
        /// <param name="noRetry">
        /// Indicates whether the request should not be retried if processing fails.
        /// </param>
        /// <param name="errorMessages">
        /// Error messages recorded from failed processing attempts.
        /// </param>
        /// <param name="handledAt">
        /// The timestamp when the request was marked as handled, if applicable.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.UpdateRequestResponse> ActorRunsLastRequestQueueRequestPutAsync(
            string actorId,
            string requestId,
            string uniqueKey,
            string url,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            string? forefront = default,
            string? clientKey = default,
            global::Apify.HttpMethod? method = default,
            int? retryCount = default,
            string? loadedUrl = default,
            string? payload = default,
            object? headers = default,
            global::Apify.RequestUserData? userData = default,
            bool? noRetry = default,
            global::System.Collections.Generic.IList<string>? errorMessages = default,
            global::System.DateTime? handledAt = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}