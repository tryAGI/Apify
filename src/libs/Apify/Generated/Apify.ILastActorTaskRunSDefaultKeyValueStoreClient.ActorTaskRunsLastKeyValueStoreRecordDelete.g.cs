#nullable enable

namespace Apify
{
    public partial interface ILastActorTaskRunSDefaultKeyValueStoreClient
    {
        /// <summary>
        /// Delete last task run's default store's record<br/>
        /// Removes a record specified by a key from the default key-value store of the last Actor task run.<br/>
        /// This endpoint is a shortcut for getting the last task run's `defaultKeyValueStoreId` and then using the<br/>
        /// [Delete record](/api/v2/key-value-store-record-delete) endpoint.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="recordKey">
        /// Example: someKey
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task ActorTaskRunsLastKeyValueStoreRecordDeleteAsync(
            string actorTaskId,
            string recordKey,
            string? status = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}