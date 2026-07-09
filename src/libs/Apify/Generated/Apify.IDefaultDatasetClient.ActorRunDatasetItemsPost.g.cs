#nullable enable

namespace Apify
{
    public partial interface IDefaultDatasetClient
    {
        /// <summary>
        /// Store items<br/>
        /// Appends an item or an array of items to the end of the Actor run's default dataset.<br/>
        /// This endpoint is a shortcut that resolves the run's `defaultDatasetId` and proxies to the<br/>
        /// [Store items](/api/v2/dataset-items-post) endpoint.<br/>
        /// To save bandwidth and speed up your upload, you can send the request payload compressed and set the `Content-Encoding` header accordingly.<br/>
        /// Below is a list of supported `Content-Encoding` types.<br/>
        /// * Brotli: `Content-Encoding: br`<br/>
        /// * Gzip: `Content-Encoding: gzip`<br/>
        /// * Deflate: `Content-Encoding: deflate`
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="contentEncoding"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ActorRunDatasetItemsPostAsync(
            string runId,

            global::Apify.OneOf<global::Apify.PutItemsRequest, global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>> request,
            global::Apify.ActorRunDatasetItemsPostContentEncoding? contentEncoding = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Store items<br/>
        /// Appends an item or an array of items to the end of the Actor run's default dataset.<br/>
        /// This endpoint is a shortcut that resolves the run's `defaultDatasetId` and proxies to the<br/>
        /// [Store items](/api/v2/dataset-items-post) endpoint.<br/>
        /// To save bandwidth and speed up your upload, you can send the request payload compressed and set the `Content-Encoding` header accordingly.<br/>
        /// Below is a list of supported `Content-Encoding` types.<br/>
        /// * Brotli: `Content-Encoding: br`<br/>
        /// * Gzip: `Content-Encoding: gzip`<br/>
        /// * Deflate: `Content-Encoding: deflate`
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="contentEncoding"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<string>> ActorRunDatasetItemsPostAsResponseAsync(
            string runId,

            global::Apify.OneOf<global::Apify.PutItemsRequest, global::System.Collections.Generic.IList<global::Apify.PutItemsRequest>> request,
            global::Apify.ActorRunDatasetItemsPostContentEncoding? contentEncoding = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Store items<br/>
        /// Appends an item or an array of items to the end of the Actor run's default dataset.<br/>
        /// This endpoint is a shortcut that resolves the run's `defaultDatasetId` and proxies to the<br/>
        /// [Store items](/api/v2/dataset-items-post) endpoint.<br/>
        /// To save bandwidth and speed up your upload, you can send the request payload compressed and set the `Content-Encoding` header accordingly.<br/>
        /// Below is a list of supported `Content-Encoding` types.<br/>
        /// * Brotli: `Content-Encoding: br`<br/>
        /// * Gzip: `Content-Encoding: gzip`<br/>
        /// * Deflate: `Content-Encoding: deflate`
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="contentEncoding"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ActorRunDatasetItemsPostAsync(
            string runId,
            global::Apify.ActorRunDatasetItemsPostContentEncoding? contentEncoding = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}