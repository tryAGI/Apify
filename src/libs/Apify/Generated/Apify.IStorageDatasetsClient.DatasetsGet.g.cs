#nullable enable

namespace Apify
{
    public partial interface IStorageDatasetsClient
    {
        /// <summary>
        /// Get list of datasets<br/>
        /// Lists all of a user's datasets.<br/>
        /// The response is a JSON array of objects,<br/>
        /// where each object contains basic information about one dataset.<br/>
        /// By default, the objects are sorted by the `createdAt` field in ascending<br/>
        /// order, therefore you can use pagination to incrementally fetch all datasets while new<br/>
        /// ones are still being created. To sort them in descending order, use `desc=1`<br/>
        /// parameter. The endpoint supports pagination using `limit` and `offset`<br/>
        /// parameters and it will not return more than 1000 array elements.
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
        /// <param name="unnamed">
        /// Example: true
        /// </param>
        /// <param name="ownership"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ListOfDatasetsResponse> DatasetsGetAsync(
            double? offset = default,
            double? limit = default,
            bool? desc = default,
            bool? unnamed = default,
            global::Apify.StorageOwnership? ownership = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get list of datasets<br/>
        /// Lists all of a user's datasets.<br/>
        /// The response is a JSON array of objects,<br/>
        /// where each object contains basic information about one dataset.<br/>
        /// By default, the objects are sorted by the `createdAt` field in ascending<br/>
        /// order, therefore you can use pagination to incrementally fetch all datasets while new<br/>
        /// ones are still being created. To sort them in descending order, use `desc=1`<br/>
        /// parameter. The endpoint supports pagination using `limit` and `offset`<br/>
        /// parameters and it will not return more than 1000 array elements.
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
        /// <param name="unnamed">
        /// Example: true
        /// </param>
        /// <param name="ownership"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ListOfDatasetsResponse>> DatasetsGetAsResponseAsync(
            double? offset = default,
            double? limit = default,
            bool? desc = default,
            bool? unnamed = default,
            global::Apify.StorageOwnership? ownership = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}