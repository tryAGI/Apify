#nullable enable

namespace Apify
{
    public partial interface IActorBuildsClient
    {
        /// <summary>
        /// Get user builds list<br/>
        /// Gets a list of all builds for a user. The response is a JSON array of<br/>
        /// objects, where each object contains basic information about a single build.<br/>
        /// The endpoint supports pagination using the `limit` and `offset` parameters<br/>
        /// and it will not return more than 1000 records.<br/>
        /// By default, the records are sorted by the `startedAt` field in ascending<br/>
        /// order. Therefore, you can use pagination to incrementally fetch all builds while<br/>
        /// new ones are still being started. To sort the records in descending order, use<br/>
        /// the `desc=1` parameter.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Apify.ListOfBuildsResponse> ActorBuildsGetAsync(
            double? offset = default,
            double? limit = default,
            bool? desc = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get user builds list<br/>
        /// Gets a list of all builds for a user. The response is a JSON array of<br/>
        /// objects, where each object contains basic information about a single build.<br/>
        /// The endpoint supports pagination using the `limit` and `offset` parameters<br/>
        /// and it will not return more than 1000 records.<br/>
        /// By default, the records are sorted by the `startedAt` field in ascending<br/>
        /// order. Therefore, you can use pagination to incrementally fetch all builds while<br/>
        /// new ones are still being started. To sort the records in descending order, use<br/>
        /// the `desc=1` parameter.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ListOfBuildsResponse>> ActorBuildsGetAsResponseAsync(
            double? offset = default,
            double? limit = default,
            bool? desc = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}