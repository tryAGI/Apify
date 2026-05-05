#nullable enable

namespace Apify
{
    public partial interface IActorsActorVersionsClient
    {
        /// <summary>
        /// Get list of versions<br/>
        /// Gets the list of versions of a specific Actor. The response is a JSON object<br/>
        /// with the list of [Version objects](#/reference/actors/version-object), where each<br/>
        /// contains basic information about a single version.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ListOfVersionsResponse> ActVersionsGetAsync(
            string actorId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get list of versions<br/>
        /// Gets the list of versions of a specific Actor. The response is a JSON object<br/>
        /// with the list of [Version objects](#/reference/actors/version-object), where each<br/>
        /// contains basic information about a single version.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ListOfVersionsResponse>> ActVersionsGetAsResponseAsync(
            string actorId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}