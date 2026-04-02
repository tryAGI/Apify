#nullable enable

namespace Apify
{
    public partial interface IStorageKeyValueStoresClient
    {
        /// <summary>
        /// Store record<br/>
        /// Stores a value under a specific key to the key-value store.<br/>
        /// The value is passed as the PUT payload and it is stored with a MIME content<br/>
        /// type defined by the `Content-Type` header and with encoding defined by the<br/>
        /// `Content-Encoding` header.<br/>
        /// To save bandwidth, storage, and speed up your upload, send the request<br/>
        /// payload compressed with Gzip compression and add the `Content-Encoding: gzip`<br/>
        /// header. It is possible to set up another compression type with `Content-Encoding`<br/>
        /// request header.<br/>
        /// Below is a list of supported `Content-Encoding` types.<br/>
        /// * Gzip compression: `Content-Encoding: gzip`<br/>
        /// * Deflate compression: `Content-Encoding: deflate`<br/>
        /// * Brotli compression: `Content-Encoding: br`
        /// </summary>
        /// <param name="storeId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="recordKey">
        /// Example: someKey
        /// </param>
        /// <param name="contentEncoding"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> KeyValueStoreRecordPutAsync(
            string storeId,
            string recordKey,

            global::Apify.PutRecordRequest request,
            global::Apify.KeyValueStoreRecordPutContentEncoding? contentEncoding = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Store record<br/>
        /// Stores a value under a specific key to the key-value store.<br/>
        /// The value is passed as the PUT payload and it is stored with a MIME content<br/>
        /// type defined by the `Content-Type` header and with encoding defined by the<br/>
        /// `Content-Encoding` header.<br/>
        /// To save bandwidth, storage, and speed up your upload, send the request<br/>
        /// payload compressed with Gzip compression and add the `Content-Encoding: gzip`<br/>
        /// header. It is possible to set up another compression type with `Content-Encoding`<br/>
        /// request header.<br/>
        /// Below is a list of supported `Content-Encoding` types.<br/>
        /// * Gzip compression: `Content-Encoding: gzip`<br/>
        /// * Deflate compression: `Content-Encoding: deflate`<br/>
        /// * Brotli compression: `Content-Encoding: br`
        /// </summary>
        /// <param name="storeId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="recordKey">
        /// Example: someKey
        /// </param>
        /// <param name="contentEncoding"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<string>> KeyValueStoreRecordPutAsResponseAsync(
            string storeId,
            string recordKey,

            global::Apify.PutRecordRequest request,
            global::Apify.KeyValueStoreRecordPutContentEncoding? contentEncoding = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Store record<br/>
        /// Stores a value under a specific key to the key-value store.<br/>
        /// The value is passed as the PUT payload and it is stored with a MIME content<br/>
        /// type defined by the `Content-Type` header and with encoding defined by the<br/>
        /// `Content-Encoding` header.<br/>
        /// To save bandwidth, storage, and speed up your upload, send the request<br/>
        /// payload compressed with Gzip compression and add the `Content-Encoding: gzip`<br/>
        /// header. It is possible to set up another compression type with `Content-Encoding`<br/>
        /// request header.<br/>
        /// Below is a list of supported `Content-Encoding` types.<br/>
        /// * Gzip compression: `Content-Encoding: gzip`<br/>
        /// * Deflate compression: `Content-Encoding: deflate`<br/>
        /// * Brotli compression: `Content-Encoding: br`
        /// </summary>
        /// <param name="storeId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="recordKey">
        /// Example: someKey
        /// </param>
        /// <param name="contentEncoding"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> KeyValueStoreRecordPutAsync(
            string storeId,
            string recordKey,
            global::Apify.KeyValueStoreRecordPutContentEncoding? contentEncoding = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}