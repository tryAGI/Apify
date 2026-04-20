#nullable enable

namespace Apify
{
    public partial interface ILastActorTaskRunSDefaultKeyValueStoreClient
    {
        /// <summary>
        /// Download last task run's default store's records<br/>
        /// Downloads all records from the default key-value store of the last Actor task run as a ZIP archive.<br/>
        /// This endpoint is a shortcut for getting the last task run's `defaultKeyValueStoreId` and then using the<br/>
        /// [Download records](/api/v2/key-value-store-records-get) endpoint.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="collection">
        /// Example: my-collection
        /// </param>
        /// <param name="prefix">
        /// Example: my-prefix/
        /// </param>
        /// <param name="signature">
        /// Example: 2wTI46Bg8qWQrV7tavlPI
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ActorTaskRunsLastKeyValueStoreRecordsGetAsync(
            string actorTaskId,
            string? status = default,
            string? collection = default,
            string? prefix = default,
            string? signature = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}