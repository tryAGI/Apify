#nullable enable

namespace Apify
{
    public partial interface ILastActorTaskRunSDefaultDatasetClient
    {
        /// <summary>
        /// Get last task run's dataset statistics<br/>
        /// Returns statistics for the last Actor task run's default dataset.<br/>
        /// This endpoint is a shortcut that resolves the last task run's `defaultDatasetId` and proxies to the<br/>
        /// [Get dataset statistics](/api/v2/dataset-statistics-get) endpoint.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.DatasetStatisticsResponse> ActorTaskRunsLastDatasetStatisticsGetAsync(
            string actorTaskId,
            string? status = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}