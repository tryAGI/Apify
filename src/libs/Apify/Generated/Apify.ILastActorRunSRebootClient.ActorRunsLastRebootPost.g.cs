#nullable enable

namespace Apify
{
    public partial interface ILastActorRunSRebootClient
    {
        /// <summary>
        /// Reboot Actor's last run<br/>
        /// Reboots the last run of the specified Actor and returns an object that<br/>
        /// contains all the details about the rebooted run.<br/>
        /// This endpoint is a shortcut for [Reboot run](#/reference/actor-runs/reboot-run/reboot-run)<br/>
        /// on the Actor's last run. Only runs with status `RUNNING` can be rebooted. The run's<br/>
        /// container will be restarted, so any data not persisted in the key-value store, dataset,<br/>
        /// or request queue will be lost.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.RunResponse> ActorRunsLastRebootPostAsync(
            string actorId,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reboot Actor's last run<br/>
        /// Reboots the last run of the specified Actor and returns an object that<br/>
        /// contains all the details about the rebooted run.<br/>
        /// This endpoint is a shortcut for [Reboot run](#/reference/actor-runs/reboot-run/reboot-run)<br/>
        /// on the Actor's last run. Only runs with status `RUNNING` can be rebooted. The run's<br/>
        /// container will be restarted, so any data not persisted in the key-value store, dataset,<br/>
        /// or request queue will be lost.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="origin"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.RunResponse>> ActorRunsLastRebootPostAsResponseAsync(
            string actorId,
            string? status = default,
            global::Apify.RunOrigin? origin = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}