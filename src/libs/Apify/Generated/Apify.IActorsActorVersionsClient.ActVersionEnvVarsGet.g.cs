#nullable enable

namespace Apify
{
    public partial interface IActorsActorVersionsClient
    {
        /// <summary>
        /// Get list of environment variables<br/>
        /// Gets the list of environment variables for a specific version of an Actor.<br/>
        /// The response is a JSON object with the list of [EnvVar objects](#/reference/actors/environment-variable-object), where each contains basic information about a single environment variable.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="versionNumber">
        /// Example: 0.1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ListOfEnvVarsResponse> ActVersionEnvVarsGetAsync(
            string actorId,
            string versionNumber,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}