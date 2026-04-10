#nullable enable

namespace Apify
{
    public partial interface IActorRunsClient
    {
        /// <summary>
        /// Reboot run<br/>
        /// Reboots an Actor run and returns an object that contains all the details<br/>
        /// about the rebooted run.<br/>
        /// Only runs that are running, i.e. runs with status `RUNNING` can be rebooted.<br/>
        /// The run's container will be restarted, so any data not persisted in the<br/>
        /// key-value store, dataset, or request queue will be lost.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.RunResponse> ActorRunRebootPostAsync(
            string runId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}