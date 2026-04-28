#nullable enable

namespace Apify
{
    public partial interface IActorsActorRunsClient
    {
        /// <summary>
        /// Run Actor<br/>
        /// Runs an Actor and immediately returns without waiting for the run to finish.<br/>
        /// The POST payload including its `Content-Type` header is passed as `INPUT` to<br/>
        /// the Actor (usually `application/json`).<br/>
        /// The Actor is started with the default options; you can override them using<br/>
        /// various URL query parameters.<br/>
        /// The response is the Run object as returned by the [Get<br/>
        /// run](#/reference/actor-runs/run-object-and-its-storages/get-run) API<br/>
        /// endpoint.<br/>
        /// If you want to wait for the run to finish and receive the actual output of<br/>
        /// the Actor as the response, please use one of the [Run Actor<br/>
        /// synchronously](#/reference/actors/run-actor-synchronously) API endpoints<br/>
        /// instead.<br/>
        /// To fetch the Actor run results that are typically stored in the default<br/>
        /// dataset, you'll need to pass the ID received in the `defaultDatasetId` field<br/>
        /// received in the response JSON to the [Get dataset items](#/reference/datasets/item-collection/get-items)<br/>
        /// API endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
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
        /// <param name="forcePermissionLevel">
        /// Example: LIMITED_PERMISSIONS
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.RunResponse> ActRunsPostAsync(
            string actorId,

            object request,
            double? timeout = default,
            double? memory = default,
            double? maxItems = default,
            double? maxTotalChargeUsd = default,
            bool? restartOnError = default,
            string? build = default,
            double? waitForFinish = default,
            byte[]? webhooks = default,
            global::Apify.ActRunsPostForcePermissionLevel? forcePermissionLevel = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Actor<br/>
        /// Runs an Actor and immediately returns without waiting for the run to finish.<br/>
        /// The POST payload including its `Content-Type` header is passed as `INPUT` to<br/>
        /// the Actor (usually `application/json`).<br/>
        /// The Actor is started with the default options; you can override them using<br/>
        /// various URL query parameters.<br/>
        /// The response is the Run object as returned by the [Get<br/>
        /// run](#/reference/actor-runs/run-object-and-its-storages/get-run) API<br/>
        /// endpoint.<br/>
        /// If you want to wait for the run to finish and receive the actual output of<br/>
        /// the Actor as the response, please use one of the [Run Actor<br/>
        /// synchronously](#/reference/actors/run-actor-synchronously) API endpoints<br/>
        /// instead.<br/>
        /// To fetch the Actor run results that are typically stored in the default<br/>
        /// dataset, you'll need to pass the ID received in the `defaultDatasetId` field<br/>
        /// received in the response JSON to the [Get dataset items](#/reference/datasets/item-collection/get-items)<br/>
        /// API endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
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
        /// <param name="forcePermissionLevel">
        /// Example: LIMITED_PERMISSIONS
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.RunResponse>> ActRunsPostAsResponseAsync(
            string actorId,

            object request,
            double? timeout = default,
            double? memory = default,
            double? maxItems = default,
            double? maxTotalChargeUsd = default,
            bool? restartOnError = default,
            string? build = default,
            double? waitForFinish = default,
            byte[]? webhooks = default,
            global::Apify.ActRunsPostForcePermissionLevel? forcePermissionLevel = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Actor<br/>
        /// Runs an Actor and immediately returns without waiting for the run to finish.<br/>
        /// The POST payload including its `Content-Type` header is passed as `INPUT` to<br/>
        /// the Actor (usually `application/json`).<br/>
        /// The Actor is started with the default options; you can override them using<br/>
        /// various URL query parameters.<br/>
        /// The response is the Run object as returned by the [Get<br/>
        /// run](#/reference/actor-runs/run-object-and-its-storages/get-run) API<br/>
        /// endpoint.<br/>
        /// If you want to wait for the run to finish and receive the actual output of<br/>
        /// the Actor as the response, please use one of the [Run Actor<br/>
        /// synchronously](#/reference/actors/run-actor-synchronously) API endpoints<br/>
        /// instead.<br/>
        /// To fetch the Actor run results that are typically stored in the default<br/>
        /// dataset, you'll need to pass the ID received in the `defaultDatasetId` field<br/>
        /// received in the response JSON to the [Get dataset items](#/reference/datasets/item-collection/get-items)<br/>
        /// API endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
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
        /// <param name="forcePermissionLevel">
        /// Example: LIMITED_PERMISSIONS
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.RunResponse> ActRunsPostAsync(
            string actorId,
            double? timeout = default,
            double? memory = default,
            double? maxItems = default,
            double? maxTotalChargeUsd = default,
            bool? restartOnError = default,
            string? build = default,
            double? waitForFinish = default,
            byte[]? webhooks = default,
            global::Apify.ActRunsPostForcePermissionLevel? forcePermissionLevel = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}