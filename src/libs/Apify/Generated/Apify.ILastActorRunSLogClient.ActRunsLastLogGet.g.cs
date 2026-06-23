#nullable enable

namespace Apify
{
    public partial interface ILastActorRunSLogClient
    {
        /// <summary>
        /// Get last Actor run's log<br/>
        /// Retrieves last Actor run's logs.<br/>
        /// This endpoint is a shortcut for getting last Actor run's log. Same as [Get log](/api/v2/log-get) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
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
        global::System.Threading.Tasks.Task<string> ActRunsLastLogGetAsync(
            string actorId,
            string? status = default,
            bool? stream = default,
            bool? download = default,
            bool? raw = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get last Actor run's log<br/>
        /// Retrieves last Actor run's logs.<br/>
        /// This endpoint is a shortcut for getting last Actor run's log. Same as [Get log](/api/v2/log-get) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
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
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<string>> ActRunsLastLogGetAsResponseAsync(
            string actorId,
            string? status = default,
            bool? stream = default,
            bool? download = default,
            bool? raw = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}