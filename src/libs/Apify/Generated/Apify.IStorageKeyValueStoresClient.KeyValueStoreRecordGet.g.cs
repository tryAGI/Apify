#nullable enable

namespace Apify
{
    public partial interface IStorageKeyValueStoresClient
    {
        /// <summary>
        /// Get record<br/>
        /// Gets a value stored in the key-value store under a specific key.<br/>
        /// The response body has the same `Content-Encoding` header as it was set in<br/>
        /// [Put record](#tag/Key-value-storesRecord/operation/keyValueStore_record_put).<br/>
        /// If the request does not define the `Accept-Encoding` HTTP header with the<br/>
        /// right encoding, the record will be decompressed.<br/>
        /// Most HTTP clients support decompression by default. After using the HTTP<br/>
        /// client with decompression support, the `Accept-Encoding` header is set by<br/>
        /// the client and body is decompressed automatically.<br/>
        /// Please note that for security reasons, Apify API can perform small modifications<br/>
        /// to HTML documents before they are served via this endpoint. To fetch the raw HTML<br/>
        /// content without any modifications, use the `attachment` query parameter.
        /// </summary>
        /// <param name="storeId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="recordKey">
        /// Example: someKey
        /// </param>
        /// <param name="attachment">
        /// Example: true
        /// </param>
        /// <param name="signature">
        /// Example: 2wTI46Bg8qWQrV7tavlPI
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.RecordResponse> KeyValueStoreRecordGetAsync(
            string storeId,
            string recordKey,
            bool? attachment = default,
            string? signature = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get record<br/>
        /// Gets a value stored in the key-value store under a specific key.<br/>
        /// The response body has the same `Content-Encoding` header as it was set in<br/>
        /// [Put record](#tag/Key-value-storesRecord/operation/keyValueStore_record_put).<br/>
        /// If the request does not define the `Accept-Encoding` HTTP header with the<br/>
        /// right encoding, the record will be decompressed.<br/>
        /// Most HTTP clients support decompression by default. After using the HTTP<br/>
        /// client with decompression support, the `Accept-Encoding` header is set by<br/>
        /// the client and body is decompressed automatically.<br/>
        /// Please note that for security reasons, Apify API can perform small modifications<br/>
        /// to HTML documents before they are served via this endpoint. To fetch the raw HTML<br/>
        /// content without any modifications, use the `attachment` query parameter.
        /// </summary>
        /// <param name="storeId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="recordKey">
        /// Example: someKey
        /// </param>
        /// <param name="attachment">
        /// Example: true
        /// </param>
        /// <param name="signature">
        /// Example: 2wTI46Bg8qWQrV7tavlPI
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.RecordResponse>> KeyValueStoreRecordGetAsResponseAsync(
            string storeId,
            string recordKey,
            bool? attachment = default,
            string? signature = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}