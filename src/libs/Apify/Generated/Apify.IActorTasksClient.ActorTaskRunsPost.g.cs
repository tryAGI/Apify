#nullable enable

namespace Apify
{
    public partial interface IActorTasksClient
    {
        /// <summary>
        /// Run task<br/>
        /// Runs an Actor task and immediately returns without waiting for the run to<br/>
        /// finish.<br/>
        /// Optionally, you can override the Actor input configuration by passing a JSON<br/>
        /// object as the POST payload and setting the `Content-Type: application/json` HTTP header.<br/>
        /// Note that if the object in the POST payload does not define a particular<br/>
        /// input property, the Actor run uses the default value defined by the task (or Actor's input<br/>
        /// schema if not defined by the task).<br/>
        /// The response is the Actor Run object as returned by the [Get<br/>
        /// run](#/reference/actor-runs/run-object-and-its-storages/get-run) endpoint.<br/>
        /// If you want to wait for the run to finish and receive the actual output of<br/>
        /// the Actor run as the response, use one of the [Run task<br/>
        /// synchronously](#/reference/actor-tasks/run-task-synchronously) API endpoints<br/>
        /// instead.<br/>
        /// To fetch the Actor run results that are typically stored in the default<br/>
        /// dataset, you'll need to pass the ID received in the `defaultDatasetId` field<br/>
        /// received in the response JSON to the<br/>
        /// [Get dataset items](#/reference/datasets/item-collection/get-items) API endpoint.
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
        /// <param name="maxTotalChargeUsd">
        /// Example: 5
        /// </param>
        /// <param name="restartOnError">
        /// Example: false
        /// </param>
        /// <param name="build">
        /// Example: 0.1.234
        /// </param>
        /// <param name="waitForFinish">
        /// Example: 60
        /// </param>
        /// <param name="webhooks">
        /// Example: dGhpcyBpcyBqdXN0IGV4YW1wbGUK...
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ActorTaskRunsPostResponse> ActorTaskRunsPostAsync(
            string actorTaskId,

            object request,
            double? timeout = default,
            double? memory = default,
            double? maxItems = default,
            double? maxTotalChargeUsd = default,
            bool? restartOnError = default,
            string? build = default,
            double? waitForFinish = default,
            string? webhooks = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run task<br/>
        /// Runs an Actor task and immediately returns without waiting for the run to<br/>
        /// finish.<br/>
        /// Optionally, you can override the Actor input configuration by passing a JSON<br/>
        /// object as the POST payload and setting the `Content-Type: application/json` HTTP header.<br/>
        /// Note that if the object in the POST payload does not define a particular<br/>
        /// input property, the Actor run uses the default value defined by the task (or Actor's input<br/>
        /// schema if not defined by the task).<br/>
        /// The response is the Actor Run object as returned by the [Get<br/>
        /// run](#/reference/actor-runs/run-object-and-its-storages/get-run) endpoint.<br/>
        /// If you want to wait for the run to finish and receive the actual output of<br/>
        /// the Actor run as the response, use one of the [Run task<br/>
        /// synchronously](#/reference/actor-tasks/run-task-synchronously) API endpoints<br/>
        /// instead.<br/>
        /// To fetch the Actor run results that are typically stored in the default<br/>
        /// dataset, you'll need to pass the ID received in the `defaultDatasetId` field<br/>
        /// received in the response JSON to the<br/>
        /// [Get dataset items](#/reference/datasets/item-collection/get-items) API endpoint.
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
        /// <param name="maxTotalChargeUsd">
        /// Example: 5
        /// </param>
        /// <param name="restartOnError">
        /// Example: false
        /// </param>
        /// <param name="build">
        /// Example: 0.1.234
        /// </param>
        /// <param name="waitForFinish">
        /// Example: 60
        /// </param>
        /// <param name="webhooks">
        /// Example: dGhpcyBpcyBqdXN0IGV4YW1wbGUK...
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ActorTaskRunsPostResponse>> ActorTaskRunsPostAsResponseAsync(
            string actorTaskId,

            object request,
            double? timeout = default,
            double? memory = default,
            double? maxItems = default,
            double? maxTotalChargeUsd = default,
            bool? restartOnError = default,
            string? build = default,
            double? waitForFinish = default,
            string? webhooks = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run task<br/>
        /// Runs an Actor task and immediately returns without waiting for the run to<br/>
        /// finish.<br/>
        /// Optionally, you can override the Actor input configuration by passing a JSON<br/>
        /// object as the POST payload and setting the `Content-Type: application/json` HTTP header.<br/>
        /// Note that if the object in the POST payload does not define a particular<br/>
        /// input property, the Actor run uses the default value defined by the task (or Actor's input<br/>
        /// schema if not defined by the task).<br/>
        /// The response is the Actor Run object as returned by the [Get<br/>
        /// run](#/reference/actor-runs/run-object-and-its-storages/get-run) endpoint.<br/>
        /// If you want to wait for the run to finish and receive the actual output of<br/>
        /// the Actor run as the response, use one of the [Run task<br/>
        /// synchronously](#/reference/actor-tasks/run-task-synchronously) API endpoints<br/>
        /// instead.<br/>
        /// To fetch the Actor run results that are typically stored in the default<br/>
        /// dataset, you'll need to pass the ID received in the `defaultDatasetId` field<br/>
        /// received in the response JSON to the<br/>
        /// [Get dataset items](#/reference/datasets/item-collection/get-items) API endpoint.
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
        /// <param name="maxTotalChargeUsd">
        /// Example: 5
        /// </param>
        /// <param name="restartOnError">
        /// Example: false
        /// </param>
        /// <param name="build">
        /// Example: 0.1.234
        /// </param>
        /// <param name="waitForFinish">
        /// Example: 60
        /// </param>
        /// <param name="webhooks">
        /// Example: dGhpcyBpcyBqdXN0IGV4YW1wbGUK...
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ActorTaskRunsPostResponse> ActorTaskRunsPostAsync(
            string actorTaskId,
            double? timeout = default,
            double? memory = default,
            double? maxItems = default,
            double? maxTotalChargeUsd = default,
            bool? restartOnError = default,
            string? build = default,
            double? waitForFinish = default,
            string? webhooks = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}