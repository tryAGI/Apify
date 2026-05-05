#nullable enable

namespace Apify
{
    public partial interface IActorRunsClient
    {
        /// <summary>
        /// Abort run<br/>
        /// Aborts an Actor run and returns an object that contains all the details<br/>
        /// about the run.<br/>
        /// Only runs that are starting or running are aborted. For runs with status<br/>
        /// `FINISHED`, `FAILED`, `ABORTING` and `TIMED-OUT` this call does nothing.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="gracefully">
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.RunResponse> ActorRunAbortPostAsync(
            string runId,
            bool? gracefully = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Abort run<br/>
        /// Aborts an Actor run and returns an object that contains all the details<br/>
        /// about the run.<br/>
        /// Only runs that are starting or running are aborted. For runs with status<br/>
        /// `FINISHED`, `FAILED`, `ABORTING` and `TIMED-OUT` this call does nothing.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="gracefully">
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.RunResponse>> ActorRunAbortPostAsResponseAsync(
            string runId,
            bool? gracefully = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}