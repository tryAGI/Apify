#nullable enable

namespace Apify
{
    public partial interface IDefaultStoragesClient
    {
        /// <summary>
        /// Delete default dataset<br/>
        /// Deletes default dataset associated with an Actor run.<br/>
        /// This endpoint is a shortcut for getting the last run's `defaultDatasetId` and then using the<br/>
        /// [ Delete dataset ](/api/v2/dataset-delete) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task ActorRunDatasetDeleteAsync(
            string runId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}