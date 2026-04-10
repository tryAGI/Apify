#nullable enable

namespace Apify
{
    public partial interface IActorBuildsClient
    {
        /// <summary>
        /// Delete build<br/>
        /// Delete the build. The build that is the current default build for the Actor<br/>
        /// cannot be deleted.<br/>
        /// Only users with build permissions for the Actor can delete builds.
        /// </summary>
        /// <param name="buildId">
        /// Example: soSkq9ekdmfOslopH
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task ActorBuildDeleteAsync(
            string buildId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}