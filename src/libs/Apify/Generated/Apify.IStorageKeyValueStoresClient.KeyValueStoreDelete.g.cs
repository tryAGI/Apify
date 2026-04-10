#nullable enable

namespace Apify
{
    public partial interface IStorageKeyValueStoresClient
    {
        /// <summary>
        /// Delete store<br/>
        /// Deletes a key-value store.
        /// </summary>
        /// <param name="storeId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task KeyValueStoreDeleteAsync(
            string storeId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}