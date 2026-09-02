#nullable enable

namespace Apify
{
    public partial interface IStorageRequestQueuesRequestsClient
    {
        /// <summary>
        /// Add request<br/>
        /// Adds request to the queue. Response contains ID of the request and info if<br/>
        /// request was already present in the queue or handled.<br/>
        /// If request with same `uniqueKey` was already present in the queue then<br/>
        /// returns an ID of existing request.
        /// </summary>
        /// <param name="queueId">
        /// Example: WkzbQMuFYuamGv3YF
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
        global::System.Threading.Tasks.Task<global::Apify.AddRequestResponse> RequestQueueRequestsPostAsync(
            string queueId,

            global::Apify.RequestWithoutId request,
            string? clientKey = default,
            string? forefront = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add request<br/>
        /// Adds request to the queue. Response contains ID of the request and info if<br/>
        /// request was already present in the queue or handled.<br/>
        /// If request with same `uniqueKey` was already present in the queue then<br/>
        /// returns an ID of existing request.
        /// </summary>
        /// <param name="queueId">
        /// Example: WkzbQMuFYuamGv3YF
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
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.AddRequestResponse>> RequestQueueRequestsPostAsResponseAsync(
            string queueId,

            global::Apify.RequestWithoutId request,
            string? clientKey = default,
            string? forefront = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add request<br/>
        /// Adds request to the queue. Response contains ID of the request and info if<br/>
        /// request was already present in the queue or handled.<br/>
        /// If request with same `uniqueKey` was already present in the queue then<br/>
        /// returns an ID of existing request.
        /// </summary>
        /// <param name="queueId">
        /// Example: WkzbQMuFYuamGv3YF
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
        global::System.Threading.Tasks.Task<global::Apify.AddRequestResponse> RequestQueueRequestsPostAsync(
            string queueId,
            string uniqueKey,
            string url,
            string? clientKey = default,
            string? forefront = default,
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