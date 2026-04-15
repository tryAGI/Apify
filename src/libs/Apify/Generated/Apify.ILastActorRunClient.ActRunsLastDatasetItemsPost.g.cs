#nullable enable

namespace Apify
{
    public partial interface ILastActorRunClient
    {
        /// <summary>
        /// Store items in last run's dataset<br/>
        /// Appends an item or an array of items to the end of the last Actor run's default dataset.<br/>
        /// This endpoint is a shortcut that resolves the last run's `defaultDatasetId` and proxies to the<br/>
        /// [Store items](/api/v2/dataset-items-post) endpoint.
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
        global::System.Threading.Tasks.Task<string> ActRunsLastDatasetItemsPostAsync(
            string actorId,

            global::Apify.OneOf<global::Apify.PutItemsRequest, global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>> request,
            string? status = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Store items in last run's dataset<br/>
        /// Appends an item or an array of items to the end of the last Actor run's default dataset.<br/>
        /// This endpoint is a shortcut that resolves the last run's `defaultDatasetId` and proxies to the<br/>
        /// [Store items](/api/v2/dataset-items-post) endpoint.
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
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<string>> ActRunsLastDatasetItemsPostAsResponseAsync(
            string actorId,

            global::Apify.OneOf<global::Apify.PutItemsRequest, global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>> request,
            string? status = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Store items in last run's dataset<br/>
        /// Appends an item or an array of items to the end of the last Actor run's default dataset.<br/>
        /// This endpoint is a shortcut that resolves the last run's `defaultDatasetId` and proxies to the<br/>
        /// [Store items](/api/v2/dataset-items-post) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ActRunsLastDatasetItemsPostAsync(
            string actorId,
            string? status = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}