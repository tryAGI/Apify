#nullable enable

namespace Apify
{
    public partial interface IDefaultDatasetClient
    {
        /// <summary>
        /// Update default dataset<br/>
        /// Updates the default dataset associated with an Actor run.<br/>
        /// This endpoint is a shortcut for getting the run's `defaultDatasetId` and then using the<br/>
        /// [Put dataset](/api/v2/dataset-put) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.DatasetResponse> ActorRunDatasetPutAsync(
            string runId,

            global::Apify.UpdateDatasetRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update default dataset<br/>
        /// Updates the default dataset associated with an Actor run.<br/>
        /// This endpoint is a shortcut for getting the run's `defaultDatasetId` and then using the<br/>
        /// [Put dataset](/api/v2/dataset-put) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="name"></param>
        /// <param name="generalAccess">
        /// Defines the general access level for the resource.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.DatasetResponse> ActorRunDatasetPutAsync(
            string runId,
            string? name = default,
            global::Apify.GeneralAccess? generalAccess = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}