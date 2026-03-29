#nullable enable

namespace Apify
{
    public partial interface IActorsActorVersionsClient
    {
        /// <summary>
        /// Delete environment variable<br/>
        /// Deletes a specific environment variable.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="versionNumber">
        /// Example: 0.1
        /// </param>
        /// <param name="envVarName">
        /// Example: MY_ENV_VAR
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ActVersionEnvVarDeleteAsync(
            string actorId,
            string versionNumber,
            string envVarName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}