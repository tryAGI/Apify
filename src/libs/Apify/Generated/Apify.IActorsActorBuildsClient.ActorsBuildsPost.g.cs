#nullable enable

namespace Apify
{
    public partial interface IActorsActorBuildsClient
    {
        /// <summary>
        /// Build Actor<br/>
        /// Builds an Actor.<br/>
        /// The response is the build object as returned by the<br/>
        /// [Get build](#/reference/actors/build-object/get-build) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="version">
        /// Example: 0.0
        /// </param>
        /// <param name="useCache">
        /// Example: true
        /// </param>
        /// <param name="betaPackages">
        /// Example: true
        /// </param>
        /// <param name="tag">
        /// Example: latest
        /// </param>
        /// <param name="waitForFinish">
        /// Example: 60
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.BuildResponse> ActorsBuildsPostAsync(
            string actorId,
            string version,
            bool? useCache = default,
            bool? betaPackages = default,
            string? tag = default,
            double? waitForFinish = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Build Actor<br/>
        /// Builds an Actor.<br/>
        /// The response is the build object as returned by the<br/>
        /// [Get build](#/reference/actors/build-object/get-build) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="version">
        /// Example: 0.0
        /// </param>
        /// <param name="useCache">
        /// Example: true
        /// </param>
        /// <param name="betaPackages">
        /// Example: true
        /// </param>
        /// <param name="tag">
        /// Example: latest
        /// </param>
        /// <param name="waitForFinish">
        /// Example: 60
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.BuildResponse>> ActorsBuildsPostAsResponseAsync(
            string actorId,
            string version,
            bool? useCache = default,
            bool? betaPackages = default,
            string? tag = default,
            double? waitForFinish = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}