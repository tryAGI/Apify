#nullable enable

namespace Apify
{
    public partial interface IDefaultKeyValueStoreClient
    {
        /// <summary>
        /// Delete default store<br/>
        /// Delete the default key-value store.<br/>
        /// This endpoint is a shortcut for getting the run's `defaultKeyValueStoreId` and then using the<br/>
        /// [Delete store](/api/v2/key-value-store-delete) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task ActorRunKeyValueStoreDeleteAsync(
            string runId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete default store<br/>
        /// Delete the default key-value store.<br/>
        /// This endpoint is a shortcut for getting the run's `defaultKeyValueStoreId` and then using the<br/>
        /// [Delete store](/api/v2/key-value-store-delete) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse> ActorRunKeyValueStoreDeleteAsResponseAsync(
            string runId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}