#nullable enable

namespace Apify
{
    public partial interface ILastActorRunSDefaultKeyValueStoreClient
    {
        /// <summary>
        /// Get last run's default store's list of keys<br/>
        /// Returns a list of keys for the default key-value store of the last Actor run.<br/>
        /// This endpoint is a shortcut for getting the last run's `defaultKeyValueStoreId` and then using the<br/>
        /// [Get list of keys](/api/v2/key-value-store-keys-get) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
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
        global::System.Threading.Tasks.Task<global::Apify.ListOfKeysResponse> ActorRunsLastKeyValueStoreKeysGetAsync(
            string actorId,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            string? exclusiveStartKey = default,
            double? limit = default,
            string? collection = default,
            string? prefix = default,
            string? signature = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get last run's default store's list of keys<br/>
        /// Returns a list of keys for the default key-value store of the last Actor run.<br/>
        /// This endpoint is a shortcut for getting the last run's `defaultKeyValueStoreId` and then using the<br/>
        /// [Get list of keys](/api/v2/key-value-store-keys-get) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
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
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ListOfKeysResponse>> ActorRunsLastKeyValueStoreKeysGetAsResponseAsync(
            string actorId,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            string? exclusiveStartKey = default,
            double? limit = default,
            string? collection = default,
            string? prefix = default,
            string? signature = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}