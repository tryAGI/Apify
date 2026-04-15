#nullable enable

namespace Apify
{
    public partial interface IDefaultStoragesClient
    {
        /// <summary>
        /// Get default dataset statistics<br/>
        /// Returns statistics for the Actor run's default dataset.<br/>
        /// This endpoint is a shortcut that resolves the run's `defaultDatasetId` and proxies to the<br/>
        /// [Get dataset statistics](/api/v2/dataset-statistics-get) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.DatasetStatisticsResponse> ActorRunDatasetStatisticsGetAsync(
            string runId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}