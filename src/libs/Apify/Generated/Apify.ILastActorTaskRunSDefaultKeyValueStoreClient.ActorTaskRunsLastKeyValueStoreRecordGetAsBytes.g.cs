#nullable enable

namespace Apify
{
    public partial interface ILastActorTaskRunSDefaultKeyValueStoreClient
    {
        /// <summary>
        /// Get last task run's default store's record<br/>
        /// Gets a value stored under a specific key in the default key-value store of the last Actor task run.<br/>
        /// This endpoint is a shortcut for getting the last task run's `defaultKeyValueStoreId` and then using the<br/>
        /// [Get record](/api/v2/key-value-store-record-get) endpoint.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
        /// <param name="recordKey">
        /// Example: someKey
        /// </param>
        /// <param name="signature">
        /// Example: 2wTI46Bg8qWQrV7tavlPI
        /// </param>
        /// <param name="attachment">
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ActorTaskRunsLastKeyValueStoreRecordGetAsBytesAsync(
            string actorTaskId,
            string recordKey,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            string? signature = default,
            bool? attachment = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get last task run's default store's record<br/>
        /// Gets a value stored under a specific key in the default key-value store of the last Actor task run.<br/>
        /// This endpoint is a shortcut for getting the last task run's `defaultKeyValueStoreId` and then using the<br/>
        /// [Get record](/api/v2/key-value-store-record-get) endpoint.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
        /// <param name="recordKey">
        /// Example: someKey
        /// </param>
        /// <param name="signature">
        /// Example: 2wTI46Bg8qWQrV7tavlPI
        /// </param>
        /// <param name="attachment">
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> ActorTaskRunsLastKeyValueStoreRecordGetAsBytesAsStreamAsync(
            string actorTaskId,
            string recordKey,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            string? signature = default,
            bool? attachment = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get last task run's default store's record<br/>
        /// Gets a value stored under a specific key in the default key-value store of the last Actor task run.<br/>
        /// This endpoint is a shortcut for getting the last task run's `defaultKeyValueStoreId` and then using the<br/>
        /// [Get record](/api/v2/key-value-store-record-get) endpoint.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
        /// <param name="recordKey">
        /// Example: someKey
        /// </param>
        /// <param name="signature">
        /// Example: 2wTI46Bg8qWQrV7tavlPI
        /// </param>
        /// <param name="attachment">
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<byte[]>> ActorTaskRunsLastKeyValueStoreRecordGetAsBytesAsResponseAsync(
            string actorTaskId,
            string recordKey,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            string? signature = default,
            bool? attachment = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}