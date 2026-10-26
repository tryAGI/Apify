#nullable enable

namespace Apify
{
    public partial interface IActorsActorVersionsClient
    {
        /// <summary>
        /// Create environment variable in Actor version<br/>
        /// Creates an environment variable of an Actor using values specified in an<br/>
        /// `EnvVar` object passed as<br/>
        /// JSON in the POST payload.<br/>
        /// The request must specify `name` and `value` parameters (as strings) in the<br/>
        /// JSON payload and a `Content-Type: application/json` HTTP header.<br/>
        /// ```<br/>
        /// {<br/>
        ///     "name": "ENV_VAR_NAME",<br/>
        ///     "value": "my-env-var"<br/>
        /// }<br/>
        /// ```<br/>
        /// The response is the `EnvVar`<br/>
        /// object as returned by the [Get environment variable of Actor version](/api/v2/actor-version-env-var-get)<br/>
        /// endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
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
        /// Create environment variable in Actor version<br/>
        /// Creates an environment variable of an Actor using values specified in an<br/>
        /// `EnvVar` object passed as<br/>
        /// JSON in the POST payload.<br/>
        /// The request must specify `name` and `value` parameters (as strings) in the<br/>
        /// JSON payload and a `Content-Type: application/json` HTTP header.<br/>
        /// ```<br/>
        /// {<br/>
        ///     "name": "ENV_VAR_NAME",<br/>
        ///     "value": "my-env-var"<br/>
        /// }<br/>
        /// ```<br/>
        /// The response is the `EnvVar`<br/>
        /// object as returned by the [Get environment variable of Actor version](/api/v2/actor-version-env-var-get)<br/>
        /// endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
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
        /// Create environment variable in Actor version<br/>
        /// Creates an environment variable of an Actor using values specified in an<br/>
        /// `EnvVar` object passed as<br/>
        /// JSON in the POST payload.<br/>
        /// The request must specify `name` and `value` parameters (as strings) in the<br/>
        /// JSON payload and a `Content-Type: application/json` HTTP header.<br/>
        /// ```<br/>
        /// {<br/>
        ///     "name": "ENV_VAR_NAME",<br/>
        ///     "value": "my-env-var"<br/>
        /// }<br/>
        /// ```<br/>
        /// The response is the `EnvVar`<br/>
        /// object as returned by the [Get environment variable of Actor version](/api/v2/actor-version-env-var-get)<br/>
        /// endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="versionNumber">
        /// Example: 0.1
        /// </param>
        /// <param name="name">
        /// The name of the environment variable. Can't contain `=`.
        /// </param>
        /// <param name="value">
        /// The value of the environment variable.
        /// </param>
        /// <param name="isSecret">
        /// Whether the environment variable is encrypted. Secret values aren't returned by the API.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.EnvVarResponse> ActorVersionEnvVarsPostAsync(
            string actorId,
            string versionNumber,
            string name,
            string value,
            bool? isSecret = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}