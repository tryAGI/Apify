#nullable enable

namespace Apify
{
    public partial interface IActorsActorBuildsClient
    {
        /// <summary>
        /// Get OpenAPI definition<br/>
        /// Get the OpenAPI definition for Actor builds. Two similar endpoints are available:<br/>
        /// - [First endpoint](/api/v2/actor-openapi-json-get): Requires both `actorId` and `buildId`. Use `default` as the `buildId` to get the OpenAPI schema for the default Actor build.<br/>
        /// - [Second endpoint](/api/v2/actor-build-openapi-json-get): Requires only `buildId`.<br/>
        /// Get the OpenAPI definition for a specific Actor build.<br/>
        /// To fetch the default Actor build, simply pass `default` as the `buildId`.<br/>
        /// Authentication is based on the build's unique ID. No authentication token is required.<br/>
        /// :::note<br/>
        /// You can also use the [`/api/v2/actor-build-openapi-json-get`](/api/v2/actor-build-openapi-json-get) endpoint to get the OpenAPI definition for a build.<br/>
        /// :::
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="buildId">
        /// Example: soSkq9ekdmfOslopH
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ActorOpenapiJsonGetAsync(
            string actorId,
            string buildId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get OpenAPI definition<br/>
        /// Get the OpenAPI definition for Actor builds. Two similar endpoints are available:<br/>
        /// - [First endpoint](/api/v2/actor-openapi-json-get): Requires both `actorId` and `buildId`. Use `default` as the `buildId` to get the OpenAPI schema for the default Actor build.<br/>
        /// - [Second endpoint](/api/v2/actor-build-openapi-json-get): Requires only `buildId`.<br/>
        /// Get the OpenAPI definition for a specific Actor build.<br/>
        /// To fetch the default Actor build, simply pass `default` as the `buildId`.<br/>
        /// Authentication is based on the build's unique ID. No authentication token is required.<br/>
        /// :::note<br/>
        /// You can also use the [`/api/v2/actor-build-openapi-json-get`](/api/v2/actor-build-openapi-json-get) endpoint to get the OpenAPI definition for a build.<br/>
        /// :::
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="buildId">
        /// Example: soSkq9ekdmfOslopH
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<string>> ActorOpenapiJsonGetAsResponseAsync(
            string actorId,
            string buildId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}