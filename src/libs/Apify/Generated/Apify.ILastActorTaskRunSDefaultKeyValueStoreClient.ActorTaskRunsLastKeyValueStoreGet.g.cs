#nullable enable

namespace Apify
{
    public partial interface ILastActorTaskRunSDefaultKeyValueStoreClient
    {
        /// <summary>
        /// Get last task run's default store<br/>
        /// Gets an object that contains all the details about the default key-value store of the last Actor task run.<br/>
        /// This endpoint is a shortcut for getting the last task run's `defaultKeyValueStoreId` and then using the<br/>
        /// [Get store](/api/v2/key-value-store-get) endpoint.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.KeyValueStoreResponse> ActorTaskRunsLastKeyValueStoreGetAsync(
            string actorTaskId,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get last task run's default store<br/>
        /// Gets an object that contains all the details about the default key-value store of the last Actor task run.<br/>
        /// This endpoint is a shortcut for getting the last task run's `defaultKeyValueStoreId` and then using the<br/>
        /// [Get store](/api/v2/key-value-store-get) endpoint.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.KeyValueStoreResponse>> ActorTaskRunsLastKeyValueStoreGetAsResponseAsync(
            string actorTaskId,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}