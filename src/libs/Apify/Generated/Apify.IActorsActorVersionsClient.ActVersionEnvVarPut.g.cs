#nullable enable

namespace Apify
{
    public partial interface IActorsActorVersionsClient
    {
        /// <summary>
        /// Update environment variable<br/>
        /// Updates Actor environment variable using values specified by a [EnvVar<br/>
        /// object](#/reference/actors/environment-variable-object)<br/>
        /// passed as JSON in the POST payload.<br/>
        /// If the object does not define a specific property, its value will not be<br/>
        /// updated.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP<br/>
        /// header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL. ([More<br/>
        /// info](#/introduction/authentication)).<br/>
        /// The response is the [EnvVar object](#/reference/actors/environment-variable-object) as returned by the<br/>
        /// [Get environment variable](#/reference/actors/environment-variable-object/get-environment-variable)<br/>
        /// endpoint.
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
        global::System.Threading.Tasks.Task<global::Apify.EnvVarResponse> ActVersionEnvVarPutAsync(
            string actorId,
            string versionNumber,
            string envVarName,

            global::Apify.EnvVar request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update environment variable<br/>
        /// Updates Actor environment variable using values specified by a [EnvVar<br/>
        /// object](#/reference/actors/environment-variable-object)<br/>
        /// passed as JSON in the POST payload.<br/>
        /// If the object does not define a specific property, its value will not be<br/>
        /// updated.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP<br/>
        /// header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL. ([More<br/>
        /// info](#/introduction/authentication)).<br/>
        /// The response is the [EnvVar object](#/reference/actors/environment-variable-object) as returned by the<br/>
        /// [Get environment variable](#/reference/actors/environment-variable-object/get-environment-variable)<br/>
        /// endpoint.
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
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="isSecret"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.EnvVarResponse> ActVersionEnvVarPutAsync(
            string actorId,
            string versionNumber,
            string envVarName,
            string name,
            string value,
            bool? isSecret = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}