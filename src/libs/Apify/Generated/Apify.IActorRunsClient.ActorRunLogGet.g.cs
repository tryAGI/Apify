#nullable enable

namespace Apify
{
    public partial interface IActorRunsClient
    {
        /// <summary>
        /// Get run's log<br/>
        /// Retrieves Actor run's logs.<br/>
        /// This endpoint is a shortcut for getting the run's log. Same as [Get log](/api/v2/log-get) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="stream">
        /// Example: false
        /// </param>
        /// <param name="download">
        /// Example: false
        /// </param>
        /// <param name="raw">
        /// Example: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ActorRunLogGetAsync(
            string runId,
            bool? stream = default,
            bool? download = default,
            bool? raw = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get run's log<br/>
        /// Retrieves Actor run's logs.<br/>
        /// This endpoint is a shortcut for getting the run's log. Same as [Get log](/api/v2/log-get) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="stream">
        /// Example: false
        /// </param>
        /// <param name="download">
        /// Example: false
        /// </param>
        /// <param name="raw">
        /// Example: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<string>> ActorRunLogGetAsResponseAsync(
            string runId,
            bool? stream = default,
            bool? download = default,
            bool? raw = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}