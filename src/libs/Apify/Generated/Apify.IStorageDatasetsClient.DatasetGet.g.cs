#nullable enable

namespace Apify
{
    public partial interface IStorageDatasetsClient
    {
        /// <summary>
        /// Get dataset<br/>
        /// Returns dataset object for given dataset ID.<br/>
        /// This does not return dataset items, only information about the storage itself.<br/>
        /// To retrieve dataset items, use the [List dataset items](/api/v2/dataset-items-get) endpoint.<br/>
        /// :::note<br/>
        /// Keep in mind that attributes `itemCount` and `cleanItemCount` are not propagated right away after data are pushed into a dataset.<br/>
        /// :::<br/>
        /// There is a short period (up to 5 seconds) during which these counters may not match with exact counts in dataset items.
        /// </summary>
        /// <param name="datasetId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.DatasetResponse> DatasetGetAsync(
            string datasetId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get dataset<br/>
        /// Returns dataset object for given dataset ID.<br/>
        /// This does not return dataset items, only information about the storage itself.<br/>
        /// To retrieve dataset items, use the [List dataset items](/api/v2/dataset-items-get) endpoint.<br/>
        /// :::note<br/>
        /// Keep in mind that attributes `itemCount` and `cleanItemCount` are not propagated right away after data are pushed into a dataset.<br/>
        /// :::<br/>
        /// There is a short period (up to 5 seconds) during which these counters may not match with exact counts in dataset items.
        /// </summary>
        /// <param name="datasetId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.DatasetResponse>> DatasetGetAsResponseAsync(
            string datasetId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}