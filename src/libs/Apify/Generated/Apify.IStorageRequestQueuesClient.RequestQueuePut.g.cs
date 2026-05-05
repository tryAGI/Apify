#nullable enable

namespace Apify
{
    public partial interface IStorageRequestQueuesClient
    {
        /// <summary>
        /// Update request queue<br/>
        /// Updates a request queue's name and general resource access level using a value specified by a JSON object<br/>
        /// passed in the PUT payload.<br/>
        /// The response is the updated request queue object, as returned by the<br/>
        /// [Get request queue](#/reference/request-queues/queue-collection/get-request-queue) API endpoint.
        /// </summary>
        /// <param name="queueId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.RequestQueueResponse> RequestQueuePutAsync(
            string queueId,

            global::Apify.AllOf<global::Apify.UpdateRequestQueueRequest, object> request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update request queue<br/>
        /// Updates a request queue's name and general resource access level using a value specified by a JSON object<br/>
        /// passed in the PUT payload.<br/>
        /// The response is the updated request queue object, as returned by the<br/>
        /// [Get request queue](#/reference/request-queues/queue-collection/get-request-queue) API endpoint.
        /// </summary>
        /// <param name="queueId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.RequestQueueResponse>> RequestQueuePutAsResponseAsync(
            string queueId,

            global::Apify.AllOf<global::Apify.UpdateRequestQueueRequest, object> request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update request queue<br/>
        /// Updates a request queue's name and general resource access level using a value specified by a JSON object<br/>
        /// passed in the PUT payload.<br/>
        /// The response is the updated request queue object, as returned by the<br/>
        /// [Get request queue](#/reference/request-queues/queue-collection/get-request-queue) API endpoint.
        /// </summary>
        /// <param name="queueId">
        /// Example: WkzbQMuFYuamGv3YF
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.RequestQueueResponse> RequestQueuePutAsync(
            string queueId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}