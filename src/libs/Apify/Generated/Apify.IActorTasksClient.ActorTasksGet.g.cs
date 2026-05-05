#nullable enable

namespace Apify
{
    public partial interface IActorTasksClient
    {
        /// <summary>
        /// Get list of tasks<br/>
        /// Gets the complete list of tasks that a user has created or used.<br/>
        /// The response is a list of objects in which each object contains essential<br/>
        /// information about a single task.<br/>
        /// The endpoint supports pagination using the `limit` and `offset` parameters,<br/>
        /// and it does not return more than a 1000 records.<br/>
        /// By default, the records are sorted by the `createdAt` field in ascending<br/>
        /// order; therefore you can use pagination to incrementally fetch all tasks while new<br/>
        /// ones are still being created. To sort the records in descending order, use<br/>
        /// the `desc=1` parameter.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Apify.ListOfTasksResponse> ActorTasksGetAsync(
            double? offset = default,
            double? limit = default,
            bool? desc = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get list of tasks<br/>
        /// Gets the complete list of tasks that a user has created or used.<br/>
        /// The response is a list of objects in which each object contains essential<br/>
        /// information about a single task.<br/>
        /// The endpoint supports pagination using the `limit` and `offset` parameters,<br/>
        /// and it does not return more than a 1000 records.<br/>
        /// By default, the records are sorted by the `createdAt` field in ascending<br/>
        /// order; therefore you can use pagination to incrementally fetch all tasks while new<br/>
        /// ones are still being created. To sort the records in descending order, use<br/>
        /// the `desc=1` parameter.
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ListOfTasksResponse>> ActorTasksGetAsResponseAsync(
            double? offset = default,
            double? limit = default,
            bool? desc = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}