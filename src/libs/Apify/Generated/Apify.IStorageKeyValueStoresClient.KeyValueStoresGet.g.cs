#nullable enable

namespace Apify
{
    public partial interface IStorageKeyValueStoresClient
    {
        /// <summary>
        /// Get list of key-value stores<br/>
        /// Gets the list of key-value stores owned by the user.<br/>
        /// The response is a list of objects, where each objects contains a basic<br/>
        /// information about a single key-value store.<br/>
        /// The endpoint supports pagination using the `limit` and `offset` parameters<br/>
        /// and it will not return more than 1000 array elements.<br/>
        /// By default, the records are sorted by the `createdAt` field in ascending<br/>
        /// order, therefore you can use pagination to incrementally fetch all key-value stores<br/>
        /// while new ones are still being created. To sort the records in descending order, use<br/>
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
        /// <param name="unnamed">
        /// Example: true
        /// </param>
        /// <param name="ownership"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ListOfKeyValueStoresResponse> KeyValueStoresGetAsync(
            double? offset = default,
            double? limit = default,
            bool? desc = default,
            bool? unnamed = default,
            global::Apify.StorageOwnership? ownership = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}