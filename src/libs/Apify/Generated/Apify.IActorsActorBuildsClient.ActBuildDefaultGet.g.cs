#nullable enable

namespace Apify
{
    public partial interface IActorsActorBuildsClient
    {
        /// <summary>
        /// Get default build<br/>
        /// Get the default build for an Actor.<br/>
        /// Use the optional `waitForFinish` parameter to synchronously wait for the build to finish.<br/>
        /// This avoids the need for periodic polling when waiting for the build to complete.<br/>
        /// This endpoint does not require an authentication token. Instead, calls are authenticated using the Actor's unique ID.<br/>
        /// However, if you access the endpoint without a token, certain attributes (e.g., `usageUsd` and `usageTotalUsd`) will be hidden.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="waitForFinish">
        /// Example: 60
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.BuildResponse> ActBuildDefaultGetAsync(
            string actorId,
            double? waitForFinish = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}