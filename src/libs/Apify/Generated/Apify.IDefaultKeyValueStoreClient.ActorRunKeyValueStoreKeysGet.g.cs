#nullable enable

namespace Apify
{
    public partial interface IDefaultKeyValueStoreClient
    {
        /// <summary>
        /// Get default store's list of keys<br/>
        /// Returns a list of keys for the default key-value store of the Actor run.<br/>
        /// This endpoint is a shortcut for getting the run's `defaultKeyValueStoreId` and then using the<br/>
        /// [Get list of keys](/api/v2/key-value-store-keys-get) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="exclusiveStartKey">
        /// Example: Ihnsp8YrvJ8102Kj
        /// </param>
        /// <param name="limit">
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
        global::System.Threading.Tasks.Task<global::Apify.ListOfKeysResponse> ActorRunKeyValueStoreKeysGetAsync(
            string runId,
            string? exclusiveStartKey = default,
            double? limit = default,
            string? collection = default,
            string? prefix = default,
            string? signature = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get default store's list of keys<br/>
        /// Returns a list of keys for the default key-value store of the Actor run.<br/>
        /// This endpoint is a shortcut for getting the run's `defaultKeyValueStoreId` and then using the<br/>
        /// [Get list of keys](/api/v2/key-value-store-keys-get) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="exclusiveStartKey">
        /// Example: Ihnsp8YrvJ8102Kj
        /// </param>
        /// <param name="limit">
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
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ListOfKeysResponse>> ActorRunKeyValueStoreKeysGetAsResponseAsync(
            string runId,
            string? exclusiveStartKey = default,
            double? limit = default,
            string? collection = default,
            string? prefix = default,
            string? signature = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}