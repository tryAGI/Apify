#nullable enable

namespace Apify
{
    public partial interface IActorTasksClient
    {
        /// <summary>
        /// Run task synchronously<br/>
        /// Run a specific task and return its output.<br/>
        /// The run must finish in 300&lt;!-- MAX_ACTOR_JOB_SYNC_WAIT_SECS --&gt; seconds<br/>
        /// otherwise the HTTP request fails with a timeout error (this won't abort<br/>
        /// the run itself).<br/>
        /// Beware that it might be impossible to maintain an idle HTTP connection for<br/>
        /// an extended period, due to client timeout or network conditions. Make sure your HTTP client is<br/>
        /// configured to have a long enough connection timeout.<br/>
        /// If the connection breaks, you will not receive any information about the run<br/>
        /// and its status.<br/>
        /// To run the Task asynchronously, use the<br/>
        /// [Run task asynchronously](#/reference/actor-tasks/run-collection/run-task)<br/>
        /// endpoint instead.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
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
        /// <param name="build">
        /// Example: 0.1.234
        /// </param>
        /// <param name="outputRecordKey">
        /// Example: OUTPUT
        /// </param>
        /// <param name="webhooks">
        /// Example: dGhpcyBpcyBqdXN0IGV4YW1wbGUK...
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ActorTaskRunSyncGetAsync(
            string actorTaskId,
            double? timeout = default,
            double? memory = default,
            double? maxItems = default,
            string? build = default,
            string? outputRecordKey = default,
            byte[]? webhooks = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run task synchronously<br/>
        /// Run a specific task and return its output.<br/>
        /// The run must finish in 300&lt;!-- MAX_ACTOR_JOB_SYNC_WAIT_SECS --&gt; seconds<br/>
        /// otherwise the HTTP request fails with a timeout error (this won't abort<br/>
        /// the run itself).<br/>
        /// Beware that it might be impossible to maintain an idle HTTP connection for<br/>
        /// an extended period, due to client timeout or network conditions. Make sure your HTTP client is<br/>
        /// configured to have a long enough connection timeout.<br/>
        /// If the connection breaks, you will not receive any information about the run<br/>
        /// and its status.<br/>
        /// To run the Task asynchronously, use the<br/>
        /// [Run task asynchronously](#/reference/actor-tasks/run-collection/run-task)<br/>
        /// endpoint instead.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
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
        /// <param name="build">
        /// Example: 0.1.234
        /// </param>
        /// <param name="outputRecordKey">
        /// Example: OUTPUT
        /// </param>
        /// <param name="webhooks">
        /// Example: dGhpcyBpcyBqdXN0IGV4YW1wbGUK...
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<string>> ActorTaskRunSyncGetAsResponseAsync(
            string actorTaskId,
            double? timeout = default,
            double? memory = default,
            double? maxItems = default,
            string? build = default,
            string? outputRecordKey = default,
            byte[]? webhooks = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}