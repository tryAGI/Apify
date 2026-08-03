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
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="versionNumber">
        /// Example: 0.1
        /// </param>
        /// <param name="envVarName">
        /// Example: MY_ENV_VAR
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.EnvVarResponse> ActorVersionEnvVarPostAsync(
            string actorId,
            string versionNumber,
            string envVarName,

            global::Apify.EnvVarRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update environment variable (POST)<br/>
        /// Updates Actor environment variable using values specified by a [EnvVar<br/>
        /// object](#/reference/actors/environment-variable-object)<br/>
        /// passed as JSON in the POST payload.<br/>
        /// This endpoint is an alias for the [`PUT` update environment variable](#tag/ActorsEnvironment-variable-object/operation/act_version_envVar_put) method and behaves identically.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="versionNumber">
        /// Example: 0.1
        /// </param>
        /// <param name="envVarName">
        /// Example: MY_ENV_VAR
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.EnvVarResponse>> ActorVersionEnvVarPostAsResponseAsync(
            string actorId,
            string versionNumber,
            string envVarName,

            global::Apify.EnvVarRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update environment variable (POST)<br/>
        /// Updates Actor environment variable using values specified by a [EnvVar<br/>
        /// object](#/reference/actors/environment-variable-object)<br/>
        /// passed as JSON in the POST payload.<br/>
        /// This endpoint is an alias for the [`PUT` update environment variable](#tag/ActorsEnvironment-variable-object/operation/act_version_envVar_put) method and behaves identically.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="versionNumber">
        /// Example: 0.1
        /// </param>
        /// <param name="envVarName">
        /// Example: MY_ENV_VAR
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.EnvVarResponse> ActorVersionEnvVarPostAsync(
            string actorId,
            string versionNumber,
            string envVarName,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}