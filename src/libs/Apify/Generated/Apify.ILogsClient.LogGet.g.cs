#nullable enable

namespace Apify
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// Get log<br/>
        /// Retrieves logs for a specific Actor build or run.
        /// </summary>
        /// <param name="buildOrRunId">
        /// Example: HG7ML7M8z78YcAPEB
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
        global::System.Threading.Tasks.Task<string> LogGetAsync(
            string buildOrRunId,
            bool? stream = default,
            bool? download = default,
            bool? raw = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}