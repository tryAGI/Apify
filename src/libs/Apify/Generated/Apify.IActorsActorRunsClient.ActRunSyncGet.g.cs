#nullable enable

namespace Apify
{
    public partial interface IActorsActorRunsClient
    {
        /// <summary>
        /// Without input<br/>
        /// Runs a specific Actor and returns its output.<br/>
        /// The run must finish in 300&lt;!-- MAX_ACTOR_JOB_SYNC_WAIT_SECS --&gt; seconds<br/>
        /// otherwise the API endpoint returns a timeout error.<br/>
        /// The Actor is not passed any input.<br/>
        /// Beware that it might be impossible to maintain an idle HTTP connection for a<br/>
        /// long period of time,<br/>
        /// due to client timeout or network conditions. Make sure your HTTP client is<br/>
        /// configured to have a long enough connection timeout.<br/>
        /// If the connection breaks, you will not receive any information about the run<br/>
        /// and its status.<br/>
        /// To run the Actor asynchronously, use the [Run<br/>
        /// Actor](#/reference/actors/run-collection/run-actor) API endpoint instead.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="outputRecordKey">
        /// Example: OUTPUT
        /// </param>
        /// <param name="timeout">
        /// Example: 60
        /// </param>
        /// <param name="memory">
        /// Example: 256
        /// </param>
        /// <param name="maxItems">
        /// Example: 1000
        /// </param>
        /// <param name="maxTotalChargeUsd">
        /// Example: 5
        /// </param>
        /// <param name="restartOnError">
        /// Example: false
        /// </param>
        /// <param name="build">
        /// Example: 0.1.234
        /// </param>
        /// <param name="webhooks">
        /// Example: dGhpcyBpcyBqdXN0IGV4YW1wbGUK...
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ActRunSyncGetAsync(
            string actorId,
            string? outputRecordKey = default,
            double? timeout = default,
            double? memory = default,
            double? maxItems = default,
            double? maxTotalChargeUsd = default,
            bool? restartOnError = default,
            string? build = default,
            string? webhooks = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}