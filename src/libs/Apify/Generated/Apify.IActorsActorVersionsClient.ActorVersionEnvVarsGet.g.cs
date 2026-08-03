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
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="versionNumber">
        /// Example: 0.1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ListOfEnvVarsResponse> ActorVersionEnvVarsGetAsync(
            string actorId,
            string versionNumber,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get list of environment variables<br/>
        /// Gets the list of environment variables for a specific version of an Actor.<br/>
        /// The response is a JSON object with the list of [EnvVar objects](#/reference/actors/environment-variable-object), where each contains basic information about a single environment variable.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="versionNumber">
        /// Example: 0.1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ListOfEnvVarsResponse>> ActorVersionEnvVarsGetAsResponseAsync(
            string actorId,
            string versionNumber,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}