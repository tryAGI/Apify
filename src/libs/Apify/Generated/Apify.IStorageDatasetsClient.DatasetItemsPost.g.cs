#nullable enable

namespace Apify
{
    public partial interface IStorageDatasetsClient
    {
        /// <summary>
        /// Store items<br/>
        /// Appends an item or an array of items to the end of the dataset.<br/>
        /// The POST payload is a JSON object or a JSON array of objects to save into the dataset.<br/>
        /// If the data you attempt to store in the dataset is invalid (meaning any of the items received by the API fails the validation), the whole request is discarded and the API will return a response with status code 400.<br/>
        /// For more information about dataset schema validation, see [Dataset schema](https://docs.apify.com/platform/actors/development/actor-definition/dataset-schema/validation).<br/>
        /// **IMPORTANT:** The limit of request payload size for the dataset is 5 MB. If the array exceeds the size, you'll need to split it into a number of smaller arrays.
        /// </summary>
        /// <param name="datasetId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DatasetItemsPostAsync(
            string datasetId,

            global::Apify.OneOf<global::Apify.PutItemsRequest, global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>> request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Store items<br/>
        /// Appends an item or an array of items to the end of the dataset.<br/>
        /// The POST payload is a JSON object or a JSON array of objects to save into the dataset.<br/>
        /// If the data you attempt to store in the dataset is invalid (meaning any of the items received by the API fails the validation), the whole request is discarded and the API will return a response with status code 400.<br/>
        /// For more information about dataset schema validation, see [Dataset schema](https://docs.apify.com/platform/actors/development/actor-definition/dataset-schema/validation).<br/>
        /// **IMPORTANT:** The limit of request payload size for the dataset is 5 MB. If the array exceeds the size, you'll need to split it into a number of smaller arrays.
        /// </summary>
        /// <param name="datasetId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<string>> DatasetItemsPostAsResponseAsync(
            string datasetId,

            global::Apify.OneOf<global::Apify.PutItemsRequest, global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>> request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Store items<br/>
        /// Appends an item or an array of items to the end of the dataset.<br/>
        /// The POST payload is a JSON object or a JSON array of objects to save into the dataset.<br/>
        /// If the data you attempt to store in the dataset is invalid (meaning any of the items received by the API fails the validation), the whole request is discarded and the API will return a response with status code 400.<br/>
        /// For more information about dataset schema validation, see [Dataset schema](https://docs.apify.com/platform/actors/development/actor-definition/dataset-schema/validation).<br/>
        /// **IMPORTANT:** The limit of request payload size for the dataset is 5 MB. If the array exceeds the size, you'll need to split it into a number of smaller arrays.
        /// </summary>
        /// <param name="datasetId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DatasetItemsPostAsync(
            string datasetId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}