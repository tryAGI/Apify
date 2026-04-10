#nullable enable

namespace Apify
{
    public partial interface IActorBuildsClient
    {
        /// <summary>
        /// Get log<br/>
        /// Check out [Logs](#/reference/logs) for full reference.
        /// </summary>
        /// <param name="buildId">
        /// Example: soSkq9ekdmfOslopH
        /// </param>
        /// <param name="stream">
        /// Example: false
        /// </param>
        /// <param name="download">
        /// Example: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ActorBuildLogGetAsync(
            string buildId,
            bool? stream = default,
            bool? download = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}