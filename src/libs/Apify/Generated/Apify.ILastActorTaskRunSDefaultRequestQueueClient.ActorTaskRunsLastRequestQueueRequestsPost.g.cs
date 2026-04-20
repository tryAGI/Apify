#nullable enable

namespace Apify
{
    public partial interface ILastActorTaskRunSDefaultRequestQueueClient
    {
        /// <summary>
        /// Add request to last task run's default request queue<br/>
        /// Adds a request to the default request queue of the last Actor task run.<br/>
        /// This endpoint is a shortcut for getting the last task run's `defaultRequestQueueId` and then using the<br/>
        /// [Add request](/api/v2/request-queue-requests-post) endpoint.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
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
        global::System.Threading.Tasks.Task<global::Apify.AddRequestResponse> ActorTaskRunsLastRequestQueueRequestsPostAsync(
            string actorTaskId,

            global::Apify.RequestBase request,
            string? status = default,
            string? clientKey = default,
            string? forefront = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add request to last task run's default request queue<br/>
        /// Adds a request to the default request queue of the last Actor task run.<br/>
        /// This endpoint is a shortcut for getting the last task run's `defaultRequestQueueId` and then using the<br/>
        /// [Add request](/api/v2/request-queue-requests-post) endpoint.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="forefront">
        /// Example: false
        /// </param>
        /// <param name="uniqueKey">
        /// A unique key used for request de-duplication. Requests with the same unique key are considered identical.
        /// </param>
        /// <param name="url">
        /// The URL of the request.
        /// </param>
        /// <param name="method"></param>
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
        global::System.Threading.Tasks.Task<global::Apify.AddRequestResponse> ActorTaskRunsLastRequestQueueRequestsPostAsync(
            string actorTaskId,
            string? status = default,
            string? clientKey = default,
            string? forefront = default,
            string? uniqueKey = default,
            string? url = default,
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