#nullable enable

namespace Apify
{
    public partial interface ILastActorRunSAbortClient
    {
        /// <summary>
        /// Abort Actor's last run<br/>
        /// Aborts the last run of the specified Actor and returns an object that<br/>
        /// contains all the details about the run.<br/>
        /// This endpoint is a shortcut for [Abort run](#/reference/actor-runs/abort-run/abort-run)<br/>
        /// on the Actor's last run. Only runs that are starting or running are aborted.<br/>
        /// For runs with status `FINISHED`, `FAILED`, `ABORTING` and `TIMED-OUT` this call<br/>
        /// does nothing.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
        /// <param name="gracefully">
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.RunResponse> ActorRunsLastAbortPostAsync(
            string actorId,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            bool? gracefully = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Abort Actor's last run<br/>
        /// Aborts the last run of the specified Actor and returns an object that<br/>
        /// contains all the details about the run.<br/>
        /// This endpoint is a shortcut for [Abort run](#/reference/actor-runs/abort-run/abort-run)<br/>
        /// on the Actor's last run. Only runs that are starting or running are aborted.<br/>
        /// For runs with status `FINISHED`, `FAILED`, `ABORTING` and `TIMED-OUT` this call<br/>
        /// does nothing.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
        /// <param name="gracefully">
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.RunResponse>> ActorRunsLastAbortPostAsResponseAsync(
            string actorId,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            bool? gracefully = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}