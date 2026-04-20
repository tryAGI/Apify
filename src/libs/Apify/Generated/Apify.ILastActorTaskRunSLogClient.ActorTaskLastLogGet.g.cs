#nullable enable

namespace Apify
{
    public partial interface ILastActorTaskRunSLogClient
    {
        /// <summary>
        /// Get last Actor task run's log<br/>
        /// Retrieves last Actor task run's logs.<br/>
        /// This endpoint is a shortcut for getting last Actor task run's log. Same as [Get log](/api/v2/log-get) endpoint.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="stream">
        /// Example: false
        /// </param>
        /// <param name="download">
        /// Example: false
        /// </param>
        /// <param name="raw">
        /// Example: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ActorTaskLastLogGetAsync(
            string actorTaskId,
            bool? stream = default,
            bool? download = default,
            bool? raw = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}