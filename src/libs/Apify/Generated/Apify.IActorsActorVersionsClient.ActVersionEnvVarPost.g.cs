#nullable enable

namespace Apify
{
    public partial interface IActorsActorVersionsClient
    {
        /// <summary>
        /// Update environment variable (POST)<br/>
        /// Updates Actor environment variable using values specified by a [EnvVar<br/>
        /// object](#/reference/actors/environment-variable-object)<br/>
        /// passed as JSON in the POST payload.<br/>
        /// This endpoint is an alias for the [`PUT` update environment variable](#tag/ActorsEnvironment-variable-object/operation/act_version_envVar_put) method and behaves identically.
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
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.EnvVarResponse> ActVersionEnvVarPostAsync(
            string actorId,
            string versionNumber,
            string envVarName,

            global::Apify.EnvVarRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update environment variable (POST)<br/>
        /// Updates Actor environment variable using values specified by a [EnvVar<br/>
        /// object](#/reference/actors/environment-variable-object)<br/>
        /// passed as JSON in the POST payload.<br/>
        /// This endpoint is an alias for the [`PUT` update environment variable](#tag/ActorsEnvironment-variable-object/operation/act_version_envVar_put) method and behaves identically.
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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.EnvVarResponse> ActVersionEnvVarPostAsync(
            string actorId,
            string versionNumber,
            string envVarName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}