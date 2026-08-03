#nullable enable

namespace Apify
{
    public partial interface IActorsActorBuildsClient
    {
        /// <summary>
        /// Get list of builds<br/>
        /// Gets the list of builds of a specific Actor. The response is a JSON with the<br/>
        /// list of objects, where each object contains basic information about a single build.<br/>
        /// The endpoint supports pagination using the `limit` and `offset` parameters<br/>
        /// and it will not return more than 1000 records.<br/>
        /// By default, the records are sorted by the `startedAt` field in ascending order,<br/>
        /// therefore you can use pagination to incrementally fetch all builds while new<br/>
        /// ones are still being started. To sort the records in descending order, use<br/>
        /// the `desc=1` parameter.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="offset">
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Example: 1000
        /// </param>
        /// <param name="desc">
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ListOfBuildsResponse> ActorsBuildsGetAsync(
            string actorId,
            double? offset = default,
            double? limit = default,
            bool? desc = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get list of builds<br/>
        /// Gets the list of builds of a specific Actor. The response is a JSON with the<br/>
        /// list of objects, where each object contains basic information about a single build.<br/>
        /// The endpoint supports pagination using the `limit` and `offset` parameters<br/>
        /// and it will not return more than 1000 records.<br/>
        /// By default, the records are sorted by the `startedAt` field in ascending order,<br/>
        /// therefore you can use pagination to incrementally fetch all builds while new<br/>
        /// ones are still being started. To sort the records in descending order, use<br/>
        /// the `desc=1` parameter.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="offset">
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Example: 1000
        /// </param>
        /// <param name="desc">
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ListOfBuildsResponse>> ActorsBuildsGetAsResponseAsync(
            string actorId,
            double? offset = default,
            double? limit = default,
            bool? desc = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}