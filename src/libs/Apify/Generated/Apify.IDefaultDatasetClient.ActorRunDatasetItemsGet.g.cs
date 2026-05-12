#nullable enable

namespace Apify
{
    public partial interface IDefaultDatasetClient
    {
        /// <summary>
        /// Get default dataset items<br/>
        /// Returns data stored in the default dataset of the Actor run in the desired format.<br/>
        /// This endpoint is a shortcut that resolves the run's `defaultDatasetId` and proxies to the<br/>
        /// [Get dataset items](/api/v2/dataset-items-get) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="format">
        /// Example: json
        /// </param>
        /// <param name="clean">
        /// Example: false
        /// </param>
        /// <param name="offset">
        /// Example: 0
        /// </param>
        /// <param name="limit"></param>
        /// <param name="fields">
        /// Example: myValue,myOtherValue
        /// </param>
        /// <param name="outputFields">
        /// Example: title,link
        /// </param>
        /// <param name="omit">
        /// Example: myValue,myOtherValue
        /// </param>
        /// <param name="unwind">
        /// Example: myValue,myOtherValue
        /// </param>
        /// <param name="flatten">
        /// Example: myValue
        /// </param>
        /// <param name="desc">
        /// Example: true
        /// </param>
        /// <param name="attachment">
        /// Example: true
        /// </param>
        /// <param name="delimiter">
        /// Example: ;
        /// </param>
        /// <param name="bom">
        /// Example: false
        /// </param>
        /// <param name="xmlRoot">
        /// Example: items
        /// </param>
        /// <param name="xmlRow">
        /// Example: item
        /// </param>
        /// <param name="skipHeaderRow">
        /// Example: true
        /// </param>
        /// <param name="skipHidden">
        /// Example: false
        /// </param>
        /// <param name="skipEmpty">
        /// Example: false
        /// </param>
        /// <param name="simplified">
        /// Example: false
        /// </param>
        /// <param name="view">
        /// Example: overview
        /// </param>
        /// <param name="skipFailedPages">
        /// Example: false
        /// </param>
        /// <param name="feedTitle">
        /// Example: Latest posts from r/pasta
        /// </param>
        /// <param name="feedDescription">
        /// Example: Scraped forum posts
        /// </param>
        /// <param name="signature">
        /// Example: 2wTI46Bg8qWQrV7tavlPI
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<object>> ActorRunDatasetItemsGetAsync(
            string runId,
            string? format = default,
            bool? clean = default,
            double? offset = default,
            double? limit = default,
            string? fields = default,
            string? outputFields = default,
            string? omit = default,
            string? unwind = default,
            string? flatten = default,
            bool? desc = default,
            bool? attachment = default,
            string? delimiter = default,
            bool? bom = default,
            string? xmlRoot = default,
            string? xmlRow = default,
            bool? skipHeaderRow = default,
            bool? skipHidden = default,
            bool? skipEmpty = default,
            bool? simplified = default,
            string? view = default,
            bool? skipFailedPages = default,
            string? feedTitle = default,
            string? feedDescription = default,
            string? signature = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get default dataset items<br/>
        /// Returns data stored in the default dataset of the Actor run in the desired format.<br/>
        /// This endpoint is a shortcut that resolves the run's `defaultDatasetId` and proxies to the<br/>
        /// [Get dataset items](/api/v2/dataset-items-get) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="format">
        /// Example: json
        /// </param>
        /// <param name="clean">
        /// Example: false
        /// </param>
        /// <param name="offset">
        /// Example: 0
        /// </param>
        /// <param name="limit"></param>
        /// <param name="fields">
        /// Example: myValue,myOtherValue
        /// </param>
        /// <param name="outputFields">
        /// Example: title,link
        /// </param>
        /// <param name="omit">
        /// Example: myValue,myOtherValue
        /// </param>
        /// <param name="unwind">
        /// Example: myValue,myOtherValue
        /// </param>
        /// <param name="flatten">
        /// Example: myValue
        /// </param>
        /// <param name="desc">
        /// Example: true
        /// </param>
        /// <param name="attachment">
        /// Example: true
        /// </param>
        /// <param name="delimiter">
        /// Example: ;
        /// </param>
        /// <param name="bom">
        /// Example: false
        /// </param>
        /// <param name="xmlRoot">
        /// Example: items
        /// </param>
        /// <param name="xmlRow">
        /// Example: item
        /// </param>
        /// <param name="skipHeaderRow">
        /// Example: true
        /// </param>
        /// <param name="skipHidden">
        /// Example: false
        /// </param>
        /// <param name="skipEmpty">
        /// Example: false
        /// </param>
        /// <param name="simplified">
        /// Example: false
        /// </param>
        /// <param name="view">
        /// Example: overview
        /// </param>
        /// <param name="skipFailedPages">
        /// Example: false
        /// </param>
        /// <param name="feedTitle">
        /// Example: Latest posts from r/pasta
        /// </param>
        /// <param name="feedDescription">
        /// Example: Scraped forum posts
        /// </param>
        /// <param name="signature">
        /// Example: 2wTI46Bg8qWQrV7tavlPI
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::System.Collections.Generic.IList<object>>> ActorRunDatasetItemsGetAsResponseAsync(
            string runId,
            string? format = default,
            bool? clean = default,
            double? offset = default,
            double? limit = default,
            string? fields = default,
            string? outputFields = default,
            string? omit = default,
            string? unwind = default,
            string? flatten = default,
            bool? desc = default,
            bool? attachment = default,
            string? delimiter = default,
            bool? bom = default,
            string? xmlRoot = default,
            string? xmlRow = default,
            bool? skipHeaderRow = default,
            bool? skipHidden = default,
            bool? skipEmpty = default,
            bool? simplified = default,
            string? view = default,
            bool? skipFailedPages = default,
            string? feedTitle = default,
            string? feedDescription = default,
            string? signature = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}