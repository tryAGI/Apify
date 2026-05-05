#nullable enable

namespace Apify
{
    public partial interface ILastActorRunSDefaultDatasetClient
    {
        /// <summary>
        /// Get last run's default dataset<br/>
        /// Returns the default dataset associated with the last Actor run.<br/>
        /// This endpoint is a shortcut for getting the last run's `defaultDatasetId` and then using the<br/>
        /// [Get dataset](/api/v2/dataset-get) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.DatasetResponse> ActRunsLastDatasetGetAsync(
            string actorId,
            string? status = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get last run's default dataset<br/>
        /// Returns the default dataset associated with the last Actor run.<br/>
        /// This endpoint is a shortcut for getting the last run's `defaultDatasetId` and then using the<br/>
        /// [Get dataset](/api/v2/dataset-get) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.DatasetResponse>> ActRunsLastDatasetGetAsResponseAsync(
            string actorId,
            string? status = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}