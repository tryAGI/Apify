#nullable enable

namespace Apify
{
    public partial interface IDefaultKeyValueStoreClient
    {
        /// <summary>
        /// Store record in default store<br/>
        /// Stores a value under a specific key in the default key-value store of the Actor run.<br/>
        /// This endpoint is a shortcut for getting the run's `defaultKeyValueStoreId` and then using the<br/>
        /// [Store record](/api/v2/key-value-store-record-put) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="recordKey">
        /// Example: someKey
        /// </param>
        /// <param name="contentEncoding"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ActorRunKeyValueStoreRecordPutAsync(
            string runId,
            string recordKey,

            global::Apify.PutRecordRequest request,
            global::Apify.ActorRunKeyValueStoreRecordPutContentEncoding? contentEncoding = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Store record in default store<br/>
        /// Stores a value under a specific key in the default key-value store of the Actor run.<br/>
        /// This endpoint is a shortcut for getting the run's `defaultKeyValueStoreId` and then using the<br/>
        /// [Store record](/api/v2/key-value-store-record-put) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="recordKey">
        /// Example: someKey
        /// </param>
        /// <param name="contentEncoding"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<string>> ActorRunKeyValueStoreRecordPutAsResponseAsync(
            string runId,
            string recordKey,

            global::Apify.PutRecordRequest request,
            global::Apify.ActorRunKeyValueStoreRecordPutContentEncoding? contentEncoding = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Store record in default store<br/>
        /// Stores a value under a specific key in the default key-value store of the Actor run.<br/>
        /// This endpoint is a shortcut for getting the run's `defaultKeyValueStoreId` and then using the<br/>
        /// [Store record](/api/v2/key-value-store-record-put) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="recordKey">
        /// Example: someKey
        /// </param>
        /// <param name="contentEncoding"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ActorRunKeyValueStoreRecordPutAsync(
            string runId,
            string recordKey,
            global::Apify.ActorRunKeyValueStoreRecordPutContentEncoding? contentEncoding = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}