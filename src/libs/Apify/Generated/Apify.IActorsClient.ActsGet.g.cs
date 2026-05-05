#nullable enable

namespace Apify
{
    public partial interface IActorsClient
    {
        /// <summary>
        /// Get list of Actors<br/>
        /// Gets the list of all Actors that the user created or used. The response is a<br/>
        /// list of objects, where each object contains a basic information about a single Actor.<br/>
        /// To only get Actors created by the user, add the `my=1` query parameter.<br/>
        /// The endpoint supports pagination using the `limit` and `offset` parameters<br/>
        /// and it will not return more than 1000 records.<br/>
        /// By default, the records are sorted by the `createdAt` field in ascending<br/>
        /// order, therefore you can use pagination to incrementally fetch all Actors while new<br/>
        /// ones are still being created. To sort the records in descending order, use the `desc=1` parameter.<br/>
        /// You can also sort by your last run by using the `sortBy=stats.lastRunStartedAt` query parameter.<br/>
        /// In this case, descending order means the most recently run Actor appears first.
        /// </summary>
        /// <param name="my">
        /// Example: true
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
        /// <param name="sortBy">
        /// Example: createdAt
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ListOfActorsResponse> ActsGetAsync(
            bool? my = default,
            double? offset = default,
            double? limit = default,
            bool? desc = default,
            global::Apify.ActsGetSortBy? sortBy = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get list of Actors<br/>
        /// Gets the list of all Actors that the user created or used. The response is a<br/>
        /// list of objects, where each object contains a basic information about a single Actor.<br/>
        /// To only get Actors created by the user, add the `my=1` query parameter.<br/>
        /// The endpoint supports pagination using the `limit` and `offset` parameters<br/>
        /// and it will not return more than 1000 records.<br/>
        /// By default, the records are sorted by the `createdAt` field in ascending<br/>
        /// order, therefore you can use pagination to incrementally fetch all Actors while new<br/>
        /// ones are still being created. To sort the records in descending order, use the `desc=1` parameter.<br/>
        /// You can also sort by your last run by using the `sortBy=stats.lastRunStartedAt` query parameter.<br/>
        /// In this case, descending order means the most recently run Actor appears first.
        /// </summary>
        /// <param name="my">
        /// Example: true
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
        /// <param name="sortBy">
        /// Example: createdAt
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ListOfActorsResponse>> ActsGetAsResponseAsync(
            bool? my = default,
            double? offset = default,
            double? limit = default,
            bool? desc = default,
            global::Apify.ActsGetSortBy? sortBy = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}