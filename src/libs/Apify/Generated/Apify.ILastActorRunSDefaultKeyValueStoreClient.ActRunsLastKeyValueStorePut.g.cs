#nullable enable

namespace Apify
{
    public partial interface ILastActorRunSDefaultKeyValueStoreClient
    {
        /// <summary>
        /// Update last run's default store<br/>
        /// Updates the last Actor run key-value store's name and general resource access level using a value specified by a JSON object<br/>
        /// passed in the PUT payload.<br/>
        /// This endpoint is a shortcut for getting the run's `defaultKeyValueStoreId` and then using the<br/>
        /// [Update store](/api/v2/key-value-store-put) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.KeyValueStoreResponse> ActRunsLastKeyValueStorePutAsync(
            string actorId,

            global::Apify.UpdateStoreRequest request,
            string? status = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update last run's default store<br/>
        /// Updates the last Actor run key-value store's name and general resource access level using a value specified by a JSON object<br/>
        /// passed in the PUT payload.<br/>
        /// This endpoint is a shortcut for getting the run's `defaultKeyValueStoreId` and then using the<br/>
        /// [Update store](/api/v2/key-value-store-put) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="name"></param>
        /// <param name="generalAccess">
        /// Defines the general access level for the resource.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.KeyValueStoreResponse> ActRunsLastKeyValueStorePutAsync(
            string actorId,
            string? status = default,
            string? name = default,
            global::Apify.GeneralAccess? generalAccess = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}