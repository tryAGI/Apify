#nullable enable

namespace Apify
{
    public partial interface ILastActorRunSDefaultDatasetClient
    {
        /// <summary>
        /// Get last run's dataset statistics<br/>
        /// Returns statistics for the last Actor run's default dataset.<br/>
        /// This endpoint is a shortcut that resolves the last run's `defaultDatasetId` and proxies to the<br/>
        /// [Get dataset statistics](/api/v2/dataset-statistics-get) endpoint.
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
        global::System.Threading.Tasks.Task<global::Apify.DatasetStatisticsResponse> ActRunsLastDatasetStatisticsGetAsync(
            string actorId,
            string? status = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get last run's dataset statistics<br/>
        /// Returns statistics for the last Actor run's default dataset.<br/>
        /// This endpoint is a shortcut that resolves the last run's `defaultDatasetId` and proxies to the<br/>
        /// [Get dataset statistics](/api/v2/dataset-statistics-get) endpoint.
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
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.DatasetStatisticsResponse>> ActRunsLastDatasetStatisticsGetAsResponseAsync(
            string actorId,
            string? status = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}