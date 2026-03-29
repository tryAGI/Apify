#nullable enable

namespace Apify
{
    public partial interface IStorageKeyValueStoresClient
    {
        /// <summary>
        /// Check if a record exists<br/>
        /// Check if a value is stored in the key-value store under a specific key.
        /// </summary>
        /// <param name="storeId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="recordKey">
        /// Example: someKey
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task KeyValueStoreRecordHeadAsync(
            string storeId,
            string recordKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}