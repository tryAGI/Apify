#nullable enable

namespace Apify
{
    public partial interface IActorsActorRunsClient
    {
        /// <summary>
        /// Get last run<br/>
        /// This is not a single endpoint, but an entire group of endpoints that lets you to<br/>
        /// retrieve and manage the last run of given Actor or any of its default storages.<br/>
        /// All the endpoints require an authentication token.<br/>
        /// The base path represents the last Actor run object is:<br/>
        /// `/v2/acts/{actorId}/runs/last{?token,status}`<br/>
        /// Using the `status` query parameter you can ensure to only get a run with a certain status<br/>
        /// (e.g. `status=SUCCEEDED`). The output of this endpoint and other query parameters<br/>
        /// are the same as in the [Run object](#/reference/actors/run-object) endpoint.<br/>
        /// ##### Convenience endpoints for last Actor run<br/>
        /// * [Dataset](/api/v2/last-actor-runs-default-dataset)<br/>
        /// * [Key-value store](/api/v2/last-actor-runs-default-key-value-store)<br/>
        /// * [Request queue](/api/v2/last-actor-runs-default-request-queue)<br/>
        /// * [Log](/api/v2/last-actor-runs-log)
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="waitForFinish">
        /// Example: 60
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.RunResponse> ActRunsLastGetAsync(
            string actorId,
            string? status = default,
            double? waitForFinish = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}