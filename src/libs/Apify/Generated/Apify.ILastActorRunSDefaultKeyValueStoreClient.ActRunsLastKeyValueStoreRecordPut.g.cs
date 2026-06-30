#nullable enable

namespace Apify
{
    public partial interface ILastActorRunSDefaultKeyValueStoreClient
    {
        /// <summary>
        /// Store record in last run's default store<br/>
        /// Stores a value under a specific key in the default key-value store of the last Actor run.<br/>
        /// This endpoint is a shortcut for getting the last run's `defaultKeyValueStoreId` and then using the<br/>
        /// [Store record](/api/v2/key-value-store-record-put) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
        /// <param name="recordKey">
        /// Example: someKey
        /// </param>
        /// <param name="contentEncoding"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ActRunsLastKeyValueStoreRecordPutAsync(
            string actorId,
            string recordKey,

            global::Apify.PutRecordRequest request,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            global::Apify.ActRunsLastKeyValueStoreRecordPutContentEncoding? contentEncoding = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Store record in last run's default store<br/>
        /// Stores a value under a specific key in the default key-value store of the last Actor run.<br/>
        /// This endpoint is a shortcut for getting the last run's `defaultKeyValueStoreId` and then using the<br/>
        /// [Store record](/api/v2/key-value-store-record-put) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
        /// <param name="recordKey">
        /// Example: someKey
        /// </param>
        /// <param name="contentEncoding"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<string>> ActRunsLastKeyValueStoreRecordPutAsResponseAsync(
            string actorId,
            string recordKey,

            global::Apify.PutRecordRequest request,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            global::Apify.ActRunsLastKeyValueStoreRecordPutContentEncoding? contentEncoding = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Store record in last run's default store<br/>
        /// Stores a value under a specific key in the default key-value store of the last Actor run.<br/>
        /// This endpoint is a shortcut for getting the last run's `defaultKeyValueStoreId` and then using the<br/>
        /// [Store record](/api/v2/key-value-store-record-put) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
        /// <param name="recordKey">
        /// Example: someKey
        /// </param>
        /// <param name="contentEncoding"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ActRunsLastKeyValueStoreRecordPutAsync(
            string actorId,
            string recordKey,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            global::Apify.ActRunsLastKeyValueStoreRecordPutContentEncoding? contentEncoding = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}