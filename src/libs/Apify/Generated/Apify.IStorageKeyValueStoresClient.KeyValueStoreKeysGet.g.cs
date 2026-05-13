#nullable enable

namespace Apify
{
    public partial interface IStorageKeyValueStoresClient
    {
        /// <summary>
        /// Get list of keys<br/>
        /// Returns a list of objects describing keys of a given key-value store, as<br/>
        /// well as some information about the values (e.g. size).<br/>
        /// This endpoint is paginated using `exclusiveStartKey` and `limit` parameters<br/>
        /// - see [Pagination](/api/v2#using-key) for more details.
        /// </summary>
        /// <param name="storeId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="exclusiveStartKey">
        /// Example: Ihnsp8YrvJ8102Kj
        /// </param>
        /// <param name="limit">
        /// Default Value: 1000<br/>
        /// Example: 100
        /// </param>
        /// <param name="collection">
        /// Example: postImages
        /// </param>
        /// <param name="prefix">
        /// Example: post-images-
        /// </param>
        /// <param name="signature">
        /// Example: 2wTI46Bg8qWQrV7tavlPI
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ListOfKeysResponse> KeyValueStoreKeysGetAsync(
            string storeId,
            string? exclusiveStartKey = default,
            double? limit = default,
            string? collection = default,
            string? prefix = default,
            string? signature = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get list of keys<br/>
        /// Returns a list of objects describing keys of a given key-value store, as<br/>
        /// well as some information about the values (e.g. size).<br/>
        /// This endpoint is paginated using `exclusiveStartKey` and `limit` parameters<br/>
        /// - see [Pagination](/api/v2#using-key) for more details.
        /// </summary>
        /// <param name="storeId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="exclusiveStartKey">
        /// Example: Ihnsp8YrvJ8102Kj
        /// </param>
        /// <param name="limit">
        /// Default Value: 1000<br/>
        /// Example: 100
        /// </param>
        /// <param name="collection">
        /// Example: postImages
        /// </param>
        /// <param name="prefix">
        /// Example: post-images-
        /// </param>
        /// <param name="signature">
        /// Example: 2wTI46Bg8qWQrV7tavlPI
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ListOfKeysResponse>> KeyValueStoreKeysGetAsResponseAsync(
            string storeId,
            string? exclusiveStartKey = default,
            double? limit = default,
            string? collection = default,
            string? prefix = default,
            string? signature = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}