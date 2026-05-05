#nullable enable

namespace Apify
{
    public partial interface IActorTasksClient
    {
        /// <summary>
        /// Get list of webhooks<br/>
        /// Gets the list of webhooks of a specific Actor task. The response is a JSON<br/>
        /// with the list of objects, where each object contains basic information about a single webhook.<br/>
        /// The endpoint supports pagination using the `limit` and `offset` parameters<br/>
        /// and it will not return more than 1000 records.<br/>
        /// By default, the records are sorted by the `createdAt` field in ascending<br/>
        /// order, to sort the records in descending order, use the `desc=1` parameter.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="offset">
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Example: 1000
        /// </param>
        /// <param name="desc">
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ActorTaskWebhooksGetResponse> ActorTaskWebhooksGetAsync(
            string actorTaskId,
            double? offset = default,
            double? limit = default,
            bool? desc = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get list of webhooks<br/>
        /// Gets the list of webhooks of a specific Actor task. The response is a JSON<br/>
        /// with the list of objects, where each object contains basic information about a single webhook.<br/>
        /// The endpoint supports pagination using the `limit` and `offset` parameters<br/>
        /// and it will not return more than 1000 records.<br/>
        /// By default, the records are sorted by the `createdAt` field in ascending<br/>
        /// order, to sort the records in descending order, use the `desc=1` parameter.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="offset">
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Example: 1000
        /// </param>
        /// <param name="desc">
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ActorTaskWebhooksGetResponse>> ActorTaskWebhooksGetAsResponseAsync(
            string actorTaskId,
            double? offset = default,
            double? limit = default,
            bool? desc = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}