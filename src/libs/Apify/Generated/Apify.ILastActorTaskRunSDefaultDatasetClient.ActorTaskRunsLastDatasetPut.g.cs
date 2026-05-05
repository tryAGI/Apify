#nullable enable

namespace Apify
{
    public partial interface ILastActorTaskRunSDefaultDatasetClient
    {
        /// <summary>
        /// Update last task run's default dataset<br/>
        /// Updates the default dataset associated with the last Actor task run.<br/>
        /// This endpoint is a shortcut for getting the last task run's `defaultDatasetId` and then using the<br/>
        /// [Update dataset](/api/v2/dataset-put) endpoint.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.DatasetResponse> ActorTaskRunsLastDatasetPutAsync(
            string actorTaskId,

            global::Apify.UpdateDatasetRequest request,
            string? status = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update last task run's default dataset<br/>
        /// Updates the default dataset associated with the last Actor task run.<br/>
        /// This endpoint is a shortcut for getting the last task run's `defaultDatasetId` and then using the<br/>
        /// [Update dataset](/api/v2/dataset-put) endpoint.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.DatasetResponse>> ActorTaskRunsLastDatasetPutAsResponseAsync(
            string actorTaskId,

            global::Apify.UpdateDatasetRequest request,
            string? status = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update last task run's default dataset<br/>
        /// Updates the default dataset associated with the last Actor task run.<br/>
        /// This endpoint is a shortcut for getting the last task run's `defaultDatasetId` and then using the<br/>
        /// [Update dataset](/api/v2/dataset-put) endpoint.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
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
        global::System.Threading.Tasks.Task<global::Apify.DatasetResponse> ActorTaskRunsLastDatasetPutAsync(
            string actorTaskId,
            string? status = default,
            string? name = default,
            global::Apify.GeneralAccess? generalAccess = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}