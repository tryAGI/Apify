#nullable enable

namespace Apify
{
    public partial interface IActorsActorVersionsClient
    {
        /// <summary>
        /// Get version<br/>
        /// Gets a [Version object](#/reference/actors/version-object) that contains all the details about a specific version of an Actor.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="versionNumber">
        /// Example: 0.1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.VersionResponse> ActVersionGetAsync(
            string actorId,
            string versionNumber,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}