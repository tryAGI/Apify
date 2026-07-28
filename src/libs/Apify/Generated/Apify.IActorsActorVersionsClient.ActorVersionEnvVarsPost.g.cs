#nullable enable

namespace Apify
{
    public partial interface IActorsActorVersionsClient
    {
        /// <summary>
        /// Create environment variable<br/>
        /// Creates an environment variable of an Actor using values specified in a<br/>
        /// [EnvVar object](#/reference/actors/environment-variable-object) passed as<br/>
        /// JSON in the POST payload.<br/>
        /// The request must specify `name` and `value` parameters (as strings) in the<br/>
        /// JSON payload and a `Content-Type: application/json` HTTP header.<br/>
        /// ```<br/>
        /// {<br/>
        ///     "name": "ENV_VAR_NAME",<br/>
        ///     "value": "my-env-var"<br/>
        /// }<br/>
        /// ```<br/>
        /// The response is the [EnvVar<br/>
        /// object](#/reference/actors/environment-variable-object) as returned by the [Get environment<br/>
        /// variable](#/reference/actors/environment-variable-object/get-environment-variable)<br/>
        /// endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="versionNumber">
        /// Example: 0.1
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.EnvVarResponse> ActorVersionEnvVarsPostAsync(
            string actorId,
            string versionNumber,

            global::Apify.EnvVarRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create environment variable<br/>
        /// Creates an environment variable of an Actor using values specified in a<br/>
        /// [EnvVar object](#/reference/actors/environment-variable-object) passed as<br/>
        /// JSON in the POST payload.<br/>
        /// The request must specify `name` and `value` parameters (as strings) in the<br/>
        /// JSON payload and a `Content-Type: application/json` HTTP header.<br/>
        /// ```<br/>
        /// {<br/>
        ///     "name": "ENV_VAR_NAME",<br/>
        ///     "value": "my-env-var"<br/>
        /// }<br/>
        /// ```<br/>
        /// The response is the [EnvVar<br/>
        /// object](#/reference/actors/environment-variable-object) as returned by the [Get environment<br/>
        /// variable](#/reference/actors/environment-variable-object/get-environment-variable)<br/>
        /// endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="versionNumber">
        /// Example: 0.1
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.EnvVarResponse>> ActorVersionEnvVarsPostAsResponseAsync(
            string actorId,
            string versionNumber,

            global::Apify.EnvVarRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create environment variable<br/>
        /// Creates an environment variable of an Actor using values specified in a<br/>
        /// [EnvVar object](#/reference/actors/environment-variable-object) passed as<br/>
        /// JSON in the POST payload.<br/>
        /// The request must specify `name` and `value` parameters (as strings) in the<br/>
        /// JSON payload and a `Content-Type: application/json` HTTP header.<br/>
        /// ```<br/>
        /// {<br/>
        ///     "name": "ENV_VAR_NAME",<br/>
        ///     "value": "my-env-var"<br/>
        /// }<br/>
        /// ```<br/>
        /// The response is the [EnvVar<br/>
        /// object](#/reference/actors/environment-variable-object) as returned by the [Get environment<br/>
        /// variable](#/reference/actors/environment-variable-object/get-environment-variable)<br/>
        /// endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="versionNumber">
        /// Example: 0.1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.EnvVarResponse> ActorVersionEnvVarsPostAsync(
            string actorId,
            string versionNumber,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}