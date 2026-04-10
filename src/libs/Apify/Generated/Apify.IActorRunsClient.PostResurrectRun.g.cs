#nullable enable

namespace Apify
{
    public partial interface IActorRunsClient
    {
        /// <summary>
        /// Resurrect run<br/>
        /// Resurrects a finished Actor run and returns an object that contains all the details about the resurrected run.<br/>
        /// Only finished runs, i.e. runs with status `FINISHED`, `FAILED`, `ABORTED` and `TIMED-OUT` can be resurrected.<br/>
        /// Run status will be updated to RUNNING and its container will be restarted with the same storages<br/>
        /// (the same behaviour as when the run gets migrated to the new server).<br/>
        /// For more information, see the [Actor docs](https://docs.apify.com/platform/actors/running/runs-and-builds#resurrection-of-finished-run).
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="build">
        /// Example: 0.1.234
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.RunResponse> PostResurrectRunAsync(
            string runId,
            string? build = default,
            double? timeout = default,
            double? memory = default,
            double? maxItems = default,
            double? maxTotalChargeUsd = default,
            bool? restartOnError = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}