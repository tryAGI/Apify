#nullable enable

namespace Apify
{
    public partial interface ILastActorRunClient
    {
        /// <summary>
        /// Update last run's default dataset<br/>
        /// Updates the default dataset associated with the last Actor run.<br/>
        /// This endpoint is a shortcut for getting the last run's `defaultDatasetId` and then using the<br/>
        /// [Update dataset](/api/v2/dataset-put) endpoint.
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
        global::System.Threading.Tasks.Task<global::Apify.DatasetResponse> ActRunsLastDatasetPutAsync(
            string actorId,

            global::Apify.UpdateDatasetRequest request,
            string? status = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update last run's default dataset<br/>
        /// Updates the default dataset associated with the last Actor run.<br/>
        /// This endpoint is a shortcut for getting the last run's `defaultDatasetId` and then using the<br/>
        /// [Update dataset](/api/v2/dataset-put) endpoint.
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
        global::System.Threading.Tasks.Task<global::Apify.DatasetResponse> ActRunsLastDatasetPutAsync(
            string actorId,
            string? status = default,
            string? name = default,
            global::Apify.GeneralAccess? generalAccess = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}