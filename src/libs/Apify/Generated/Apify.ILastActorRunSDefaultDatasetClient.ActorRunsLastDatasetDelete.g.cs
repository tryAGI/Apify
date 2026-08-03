#nullable enable

namespace Apify
{
    public partial interface ILastActorRunSDefaultDatasetClient
    {
        /// <summary>
        /// Delete last run's default dataset<br/>
        /// Deletes the default dataset associated with the last Actor run.<br/>
        /// This endpoint is a shortcut for getting the last run's `defaultDatasetId` and then using the<br/>
        /// [Delete dataset](/api/v2/dataset-delete) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task ActorRunsLastDatasetDeleteAsync(
            string actorId,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete last run's default dataset<br/>
        /// Deletes the default dataset associated with the last Actor run.<br/>
        /// This endpoint is a shortcut for getting the last run's `defaultDatasetId` and then using the<br/>
        /// [Delete dataset](/api/v2/dataset-delete) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse> ActorRunsLastDatasetDeleteAsResponseAsync(
            string actorId,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}