#nullable enable

namespace Apify
{
    public partial interface IDefaultRequestQueueClient
    {
        /// <summary>
        /// Get and lock default request queue head<br/>
        /// Returns the given number of first requests from the default request queue of the Actor run<br/>
        /// and locks them for the given time.<br/>
        /// This endpoint is a shortcut for getting the run's `defaultRequestQueueId` and then using the<br/>
        /// [Get head and lock](/api/v2/request-queue-head-lock-post) endpoint.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="lockSecs">
        /// Example: 60
        /// </param>
        /// <param name="limit">
        /// Example: 25
        /// </param>
        /// <param name="clientKey">
        /// Example: client-abc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.HeadAndLockResponse> ActorRunRequestQueueHeadLockPostAsync(
            string runId,
            double lockSecs,
            double? limit = default,
            string? clientKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}