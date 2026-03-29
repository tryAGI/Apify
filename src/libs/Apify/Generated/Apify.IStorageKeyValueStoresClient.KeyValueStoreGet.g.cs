#nullable enable

namespace Apify
{
    public partial interface IStorageKeyValueStoresClient
    {
        /// <summary>
        /// Get store<br/>
        /// Gets an object that contains all the details about a specific key-value<br/>
        /// store.
        /// </summary>
        /// <param name="storeId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.KeyValueStoreResponse> KeyValueStoreGetAsync(
            string storeId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}