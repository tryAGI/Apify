#nullable enable

namespace Apify
{
    public partial interface IStorageDatasetsClient
    {
        /// <summary>
        /// Update dataset<br/>
        /// Updates a dataset's name and general resource access level using a value specified by a JSON object passed in the PUT payload.<br/>
        /// The response is the updated dataset object, as returned by the [Get dataset](/api/v2/dataset-get) API endpoint.
        /// </summary>
        /// <param name="datasetId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.DatasetResponse> DatasetPutAsync(
            string datasetId,

            global::Apify.UpdateDatasetRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update dataset<br/>
        /// Updates a dataset's name and general resource access level using a value specified by a JSON object passed in the PUT payload.<br/>
        /// The response is the updated dataset object, as returned by the [Get dataset](/api/v2/dataset-get) API endpoint.
        /// </summary>
        /// <param name="datasetId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.DatasetResponse>> DatasetPutAsResponseAsync(
            string datasetId,

            global::Apify.UpdateDatasetRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update dataset<br/>
        /// Updates a dataset's name and general resource access level using a value specified by a JSON object passed in the PUT payload.<br/>
        /// The response is the updated dataset object, as returned by the [Get dataset](/api/v2/dataset-get) API endpoint.
        /// </summary>
        /// <param name="datasetId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="name"></param>
        /// <param name="generalAccess">
        /// Defines the general access level for the resource.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.DatasetResponse> DatasetPutAsync(
            string datasetId,
            string? name = default,
            global::Apify.GeneralAccess? generalAccess = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}