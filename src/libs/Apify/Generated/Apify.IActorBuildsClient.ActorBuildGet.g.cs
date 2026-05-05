#nullable enable

namespace Apify
{
    public partial interface IActorBuildsClient
    {
        /// <summary>
        /// Get build<br/>
        /// Gets an object that contains all the details about a specific build of an<br/>
        /// Actor.<br/>
        /// By passing the optional `waitForFinish` parameter the API endpoint will<br/>
        /// synchronously wait for the build to finish. This is useful to avoid periodic<br/>
        /// polling when waiting for an Actor build to finish.<br/>
        /// This endpoint does not require the authentication token. Instead, calls are authenticated using a hard-to-guess ID of the build. However,<br/>
        /// if you access the endpoint without the token, certain attributes, such as `usageUsd` and `usageTotalUsd`, will be hidden.
        /// </summary>
        /// <param name="buildId">
        /// Example: soSkq9ekdmfOslopH
        /// </param>
        /// <param name="waitForFinish">
        /// Example: 60
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.BuildResponse> ActorBuildGetAsync(
            string buildId,
            double? waitForFinish = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get build<br/>
        /// Gets an object that contains all the details about a specific build of an<br/>
        /// Actor.<br/>
        /// By passing the optional `waitForFinish` parameter the API endpoint will<br/>
        /// synchronously wait for the build to finish. This is useful to avoid periodic<br/>
        /// polling when waiting for an Actor build to finish.<br/>
        /// This endpoint does not require the authentication token. Instead, calls are authenticated using a hard-to-guess ID of the build. However,<br/>
        /// if you access the endpoint without the token, certain attributes, such as `usageUsd` and `usageTotalUsd`, will be hidden.
        /// </summary>
        /// <param name="buildId">
        /// Example: soSkq9ekdmfOslopH
        /// </param>
        /// <param name="waitForFinish">
        /// Example: 60
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.BuildResponse>> ActorBuildGetAsResponseAsync(
            string buildId,
            double? waitForFinish = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}