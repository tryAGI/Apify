#nullable enable

namespace Apify
{
    public partial interface IActorsActorVersionsClient
    {
        /// <summary>
        /// Update environment variable in Actor version<br/>
        /// Updates Actor environment variable using values specified by an `EnvVar`<br/>
        /// object<br/>
        /// passed as JSON in the POST payload.<br/>
        /// If the object does not define a specific property, its value will not be<br/>
        /// updated.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP<br/>
        /// header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL.<br/>
        /// For details, see [Authentication](/api/v2/getting-started#authentication).<br/>
        /// The response is the `EnvVar` object as returned by the<br/>
        /// [Get environment variable of Actor version](/api/v2/actor-version-env-var-get)<br/>
        /// endpoint.
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
        global::System.Threading.Tasks.Task<global::Apify.EnvVarResponse> ActorVersionEnvVarPutAsync(
            string actorId,
            string versionNumber,
            string envVarName,

            global::Apify.EnvVarRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update environment variable in Actor version<br/>
        /// Updates Actor environment variable using values specified by an `EnvVar`<br/>
        /// object<br/>
        /// passed as JSON in the POST payload.<br/>
        /// If the object does not define a specific property, its value will not be<br/>
        /// updated.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP<br/>
        /// header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL.<br/>
        /// For details, see [Authentication](/api/v2/getting-started#authentication).<br/>
        /// The response is the `EnvVar` object as returned by the<br/>
        /// [Get environment variable of Actor version](/api/v2/actor-version-env-var-get)<br/>
        /// endpoint.
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
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.EnvVarResponse>> ActorVersionEnvVarPutAsResponseAsync(
            string actorId,
            string versionNumber,
            string envVarName,

            global::Apify.EnvVarRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update environment variable in Actor version<br/>
        /// Updates Actor environment variable using values specified by an `EnvVar`<br/>
        /// object<br/>
        /// passed as JSON in the POST payload.<br/>
        /// If the object does not define a specific property, its value will not be<br/>
        /// updated.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP<br/>
        /// header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL.<br/>
        /// For details, see [Authentication](/api/v2/getting-started#authentication).<br/>
        /// The response is the `EnvVar` object as returned by the<br/>
        /// [Get environment variable of Actor version](/api/v2/actor-version-env-var-get)<br/>
        /// endpoint.
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
        global::System.Threading.Tasks.Task<global::Apify.EnvVarResponse> ActorVersionEnvVarPutAsync(
            string actorId,
            string versionNumber,
            string envVarName,
            string name,
            string value,
            bool? isSecret = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}