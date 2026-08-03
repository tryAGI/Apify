#nullable enable

namespace Apify
{
    public partial interface IActorsActorRunsClient
    {
        /// <summary>
        /// Run Actor synchronously and return key-value store record<br/>
        /// Runs a specific Actor and returns a key-value store record.<br/>
        /// The POST payload including its `Content-Type` header is passed as `INPUT` to<br/>
        /// the Actor (usually &lt;code&gt;application/json&lt;/code&gt;).<br/>
        /// The response contains the record stored under the `OUTPUT` key in the run's<br/>
        /// default key-value store. This is a legacy approach that has been replaced by<br/>
        /// the Actor [output object](https://docs.apify.com/platform/actors/development/actor-definition/output-schema#output-object-definition);<br/>
        /// Actors aren't required to store a record under this key, so the response may<br/>
        /// not contain any data. Use the `outputRecordKey` query parameter to return a<br/>
        /// different record.<br/>
        /// The Actor is started with the default options; you can override them using<br/>
        /// various URL query parameters.<br/>
        /// If the Actor run exceeds 300&lt;!-- MAX_ACTOR_JOB_SYNC_WAIT_SECS --&gt; seconds,<br/>
        /// the HTTP response will have status 408 (Request Timeout).<br/>
        /// Beware that it might be impossible to maintain an idle HTTP connection for a<br/>
        /// long period of time, due to client timeout or network conditions. Make sure your HTTP client is<br/>
        /// configured to have a long enough connection timeout.<br/>
        /// If the connection breaks, you will not receive any information about the run<br/>
        /// and its status.<br/>
        /// To run the Actor asynchronously, use the [Run<br/>
        /// Actor](#/reference/actors/run-collection/run-actor) API endpoint instead.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ActorRunSyncPostAsync(
            string actorId,

            object request,
            string? outputRecordKey = default,
            double? timeout = default,
            double? memory = default,
            double? maxItems = default,
            double? maxTotalChargeUsd = default,
            bool? restartOnError = default,
            string? build = default,
            byte[]? webhooks = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Actor synchronously and return key-value store record<br/>
        /// Runs a specific Actor and returns a key-value store record.<br/>
        /// The POST payload including its `Content-Type` header is passed as `INPUT` to<br/>
        /// the Actor (usually &lt;code&gt;application/json&lt;/code&gt;).<br/>
        /// The response contains the record stored under the `OUTPUT` key in the run's<br/>
        /// default key-value store. This is a legacy approach that has been replaced by<br/>
        /// the Actor [output object](https://docs.apify.com/platform/actors/development/actor-definition/output-schema#output-object-definition);<br/>
        /// Actors aren't required to store a record under this key, so the response may<br/>
        /// not contain any data. Use the `outputRecordKey` query parameter to return a<br/>
        /// different record.<br/>
        /// The Actor is started with the default options; you can override them using<br/>
        /// various URL query parameters.<br/>
        /// If the Actor run exceeds 300&lt;!-- MAX_ACTOR_JOB_SYNC_WAIT_SECS --&gt; seconds,<br/>
        /// the HTTP response will have status 408 (Request Timeout).<br/>
        /// Beware that it might be impossible to maintain an idle HTTP connection for a<br/>
        /// long period of time, due to client timeout or network conditions. Make sure your HTTP client is<br/>
        /// configured to have a long enough connection timeout.<br/>
        /// If the connection breaks, you will not receive any information about the run<br/>
        /// and its status.<br/>
        /// To run the Actor asynchronously, use the [Run<br/>
        /// Actor](#/reference/actors/run-collection/run-actor) API endpoint instead.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<string>> ActorRunSyncPostAsResponseAsync(
            string actorId,

            object request,
            string? outputRecordKey = default,
            double? timeout = default,
            double? memory = default,
            double? maxItems = default,
            double? maxTotalChargeUsd = default,
            bool? restartOnError = default,
            string? build = default,
            byte[]? webhooks = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Actor synchronously and return key-value store record<br/>
        /// Runs a specific Actor and returns a key-value store record.<br/>
        /// The POST payload including its `Content-Type` header is passed as `INPUT` to<br/>
        /// the Actor (usually &lt;code&gt;application/json&lt;/code&gt;).<br/>
        /// The response contains the record stored under the `OUTPUT` key in the run's<br/>
        /// default key-value store. This is a legacy approach that has been replaced by<br/>
        /// the Actor [output object](https://docs.apify.com/platform/actors/development/actor-definition/output-schema#output-object-definition);<br/>
        /// Actors aren't required to store a record under this key, so the response may<br/>
        /// not contain any data. Use the `outputRecordKey` query parameter to return a<br/>
        /// different record.<br/>
        /// The Actor is started with the default options; you can override them using<br/>
        /// various URL query parameters.<br/>
        /// If the Actor run exceeds 300&lt;!-- MAX_ACTOR_JOB_SYNC_WAIT_SECS --&gt; seconds,<br/>
        /// the HTTP response will have status 408 (Request Timeout).<br/>
        /// Beware that it might be impossible to maintain an idle HTTP connection for a<br/>
        /// long period of time, due to client timeout or network conditions. Make sure your HTTP client is<br/>
        /// configured to have a long enough connection timeout.<br/>
        /// If the connection breaks, you will not receive any information about the run<br/>
        /// and its status.<br/>
        /// To run the Actor asynchronously, use the [Run<br/>
        /// Actor](#/reference/actors/run-collection/run-actor) API endpoint instead.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ActorRunSyncPostAsync(
            string actorId,
            string? outputRecordKey = default,
            double? timeout = default,
            double? memory = default,
            double? maxItems = default,
            double? maxTotalChargeUsd = default,
            bool? restartOnError = default,
            string? build = default,
            byte[]? webhooks = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}