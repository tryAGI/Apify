#nullable enable

namespace Apify
{
    public partial interface IStorageKeyValueStoresClient
    {
        /// <summary>
        /// Store record (POST)<br/>
        /// Stores a value under a specific key to the key-value store.<br/>
        /// This endpoint is an alias for the [`PUT` record](#tag/Key-value-storesRecord/operation/keyValueStore_record_put) method and behaves identically.
        /// </summary>
        /// <param name="storeId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="recordKey">
        /// Example: someKey
        /// </param>
        /// <param name="contentEncoding"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> KeyValueStoreRecordPostAsync(
            string storeId,
            string recordKey,

            global::Apify.PutRecordRequest request,
            global::Apify.KeyValueStoreRecordPostContentEncoding? contentEncoding = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Store record (POST)<br/>
        /// Stores a value under a specific key to the key-value store.<br/>
        /// This endpoint is an alias for the [`PUT` record](#tag/Key-value-storesRecord/operation/keyValueStore_record_put) method and behaves identically.
        /// </summary>
        /// <param name="storeId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="recordKey">
        /// Example: someKey
        /// </param>
        /// <param name="contentEncoding"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<string>> KeyValueStoreRecordPostAsResponseAsync(
            string storeId,
            string recordKey,

            global::Apify.PutRecordRequest request,
            global::Apify.KeyValueStoreRecordPostContentEncoding? contentEncoding = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Store record (POST)<br/>
        /// Stores a value under a specific key to the key-value store.<br/>
        /// This endpoint is an alias for the [`PUT` record](#tag/Key-value-storesRecord/operation/keyValueStore_record_put) method and behaves identically.
        /// </summary>
        /// <param name="storeId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="recordKey">
        /// Example: someKey
        /// </param>
        /// <param name="contentEncoding"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> KeyValueStoreRecordPostAsync(
            string storeId,
            string recordKey,
            global::Apify.KeyValueStoreRecordPostContentEncoding? contentEncoding = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}