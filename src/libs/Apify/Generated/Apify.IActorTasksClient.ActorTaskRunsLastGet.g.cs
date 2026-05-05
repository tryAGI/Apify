#nullable enable

namespace Apify
{
    public partial interface IActorTasksClient
    {
        /// <summary>
        /// Get last run<br/>
        /// This is not a single endpoint, but an entire group of endpoints that lets you to<br/>
        /// retrieve and manage the last run of given actor task or any of its default storages.<br/>
        /// All the endpoints require an authentication token.<br/>
        /// The base path represents the last actor task run object is:<br/>
        /// `/v2/actor-tasks/{actorTaskId}/runs/last{?token,status}`<br/>
        /// Using the `status` query parameter you can ensure to only get a run with a certain status<br/>
        /// (e.g. `status=SUCCEEDED`). The output of this endpoint and other query parameters<br/>
        /// are the same as in the [Run object](/api/v2/actor-run-get) endpoint.<br/>
        /// ##### Convenience endpoints for last Actor task run<br/>
        /// * [Dataset](/api/v2/last-actor-task-runs-default-dataset)<br/>
        /// * [Key-value store](/api/v2/last-actor-task-runs-default-key-value-store)<br/>
        /// * [Request queue](/api/v2/last-actor-task-runs-default-request-queue)<br/>
        /// * [Log](/api/v2/last-actor-task-runs-log)
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
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
        global::System.Threading.Tasks.Task<global::Apify.ActorTaskRunsLastGetResponse> ActorTaskRunsLastGetAsync(
            string actorTaskId,
            string? status = default,
            double? waitForFinish = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get last run<br/>
        /// This is not a single endpoint, but an entire group of endpoints that lets you to<br/>
        /// retrieve and manage the last run of given actor task or any of its default storages.<br/>
        /// All the endpoints require an authentication token.<br/>
        /// The base path represents the last actor task run object is:<br/>
        /// `/v2/actor-tasks/{actorTaskId}/runs/last{?token,status}`<br/>
        /// Using the `status` query parameter you can ensure to only get a run with a certain status<br/>
        /// (e.g. `status=SUCCEEDED`). The output of this endpoint and other query parameters<br/>
        /// are the same as in the [Run object](/api/v2/actor-run-get) endpoint.<br/>
        /// ##### Convenience endpoints for last Actor task run<br/>
        /// * [Dataset](/api/v2/last-actor-task-runs-default-dataset)<br/>
        /// * [Key-value store](/api/v2/last-actor-task-runs-default-key-value-store)<br/>
        /// * [Request queue](/api/v2/last-actor-task-runs-default-request-queue)<br/>
        /// * [Log](/api/v2/last-actor-task-runs-log)
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
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
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ActorTaskRunsLastGetResponse>> ActorTaskRunsLastGetAsResponseAsync(
            string actorTaskId,
            string? status = default,
            double? waitForFinish = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}