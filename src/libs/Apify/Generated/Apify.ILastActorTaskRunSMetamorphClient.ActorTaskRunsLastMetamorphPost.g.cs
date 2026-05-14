#nullable enable

namespace Apify
{
    public partial interface ILastActorTaskRunSMetamorphClient
    {
        /// <summary>
        /// Metamorph Actor task's last run<br/>
        /// Transforms the last run of the specified Actor task into a run of another Actor with<br/>
        /// a new input.<br/>
        /// This endpoint is a shortcut for [Metamorph run](#/reference/actor-runs/metamorph-run/metamorph-run)<br/>
        /// on the Actor task's last run.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="targetActorId">
        /// Example: HDSasDasz78YcAPEB
        /// </param>
        /// <param name="build">
        /// Example: beta
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.RunResponse> ActorTaskRunsLastMetamorphPostAsync(
            string actorTaskId,
            string targetActorId,
            string? status = default,
            string? build = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Metamorph Actor task's last run<br/>
        /// Transforms the last run of the specified Actor task into a run of another Actor with<br/>
        /// a new input.<br/>
        /// This endpoint is a shortcut for [Metamorph run](#/reference/actor-runs/metamorph-run/metamorph-run)<br/>
        /// on the Actor task's last run.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="targetActorId">
        /// Example: HDSasDasz78YcAPEB
        /// </param>
        /// <param name="build">
        /// Example: beta
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.RunResponse>> ActorTaskRunsLastMetamorphPostAsResponseAsync(
            string actorTaskId,
            string targetActorId,
            string? status = default,
            string? build = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}