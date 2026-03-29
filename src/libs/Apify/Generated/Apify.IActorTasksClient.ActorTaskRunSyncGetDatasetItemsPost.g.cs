#nullable enable

namespace Apify
{
    public partial interface IActorTasksClient
    {
        /// <summary>
        /// Run task synchronously and get dataset items<br/>
        /// Runs an Actor task and synchronously returns its dataset items.<br/>
        /// The run must finish in 300&lt;!-- MAX_ACTOR_JOB_SYNC_WAIT_SECS --&gt; seconds<br/>
        /// otherwise the HTTP request fails with a timeout error (this won't abort<br/>
        /// the run itself).<br/>
        /// Optionally, you can override the Actor input configuration by passing a JSON<br/>
        /// object as the POST payload and setting the `Content-Type: application/json` HTTP header.<br/>
        /// Note that if the object in the POST payload does not define a particular<br/>
        /// input property, the Actor run uses the default value defined by the task (or the Actor's<br/>
        /// input schema if not defined by the task).<br/>
        /// You can send all the same options in parameters as the [Get Dataset<br/>
        /// Items](#/reference/datasets/item-collection/get-items) API endpoint.<br/>
        /// Beware that it might be impossible to maintain an idle HTTP connection for<br/>
        /// an extended period, due to client timeout or network conditions. Make sure your HTTP client is<br/>
        /// configured to have a long enough connection timeout.<br/>
        /// If the connection breaks, you will not receive any information about the run<br/>
        /// and its status.<br/>
        /// Input fields from Actor task configuration can be overloaded with values<br/>
        /// passed as the POST payload.<br/>
        /// Just make sure to specify the `Content-Type` header as `application/json`<br/>
        /// and that the input is an object.<br/>
        /// To run the task asynchronously, use the [Run<br/>
        /// task](#/reference/actor-tasks/run-collection/run-task) API endpoint instead.
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
        /// <param name="webhooks">
        /// Example: dGhpcyBpcyBqdXN0IGV4YW1wbGUK...
        /// </param>
        /// <param name="format">
        /// Example: json
        /// </param>
        /// <param name="clean">
        /// Example: false
        /// </param>
        /// <param name="offset">
        /// Example: 0
        /// </param>
        /// <param name="limit"></param>
        /// <param name="fields">
        /// Example: myValue,myOtherValue
        /// </param>
        /// <param name="omit">
        /// Example: myValue,myOtherValue
        /// </param>
        /// <param name="unwind">
        /// Example: myValue,myOtherValue
        /// </param>
        /// <param name="flatten">
        /// Example: myValue
        /// </param>
        /// <param name="desc">
        /// Example: true
        /// </param>
        /// <param name="attachment">
        /// Example: true
        /// </param>
        /// <param name="delimiter">
        /// Example: ;
        /// </param>
        /// <param name="bom">
        /// Example: false
        /// </param>
        /// <param name="xmlRoot">
        /// Example: items
        /// </param>
        /// <param name="xmlRow">
        /// Example: item
        /// </param>
        /// <param name="skipHeaderRow">
        /// Example: true
        /// </param>
        /// <param name="skipHidden">
        /// Example: false
        /// </param>
        /// <param name="skipEmpty">
        /// Example: false
        /// </param>
        /// <param name="simplified">
        /// Example: false
        /// </param>
        /// <param name="skipFailedPages">
        /// Example: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ActorTaskRunSyncGetDatasetItemsPostAsync(
            string actorTaskId,

            object request,
            double? timeout = default,
            double? memory = default,
            double? maxItems = default,
            double? maxTotalChargeUsd = default,
            bool? restartOnError = default,
            string? build = default,
            string? webhooks = default,
            string? format = default,
            bool? clean = default,
            double? offset = default,
            double? limit = default,
            string? fields = default,
            string? omit = default,
            string? unwind = default,
            string? flatten = default,
            bool? desc = default,
            bool? attachment = default,
            string? delimiter = default,
            bool? bom = default,
            string? xmlRoot = default,
            string? xmlRow = default,
            bool? skipHeaderRow = default,
            bool? skipHidden = default,
            bool? skipEmpty = default,
            bool? simplified = default,
            bool? skipFailedPages = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run task synchronously and get dataset items<br/>
        /// Runs an Actor task and synchronously returns its dataset items.<br/>
        /// The run must finish in 300&lt;!-- MAX_ACTOR_JOB_SYNC_WAIT_SECS --&gt; seconds<br/>
        /// otherwise the HTTP request fails with a timeout error (this won't abort<br/>
        /// the run itself).<br/>
        /// Optionally, you can override the Actor input configuration by passing a JSON<br/>
        /// object as the POST payload and setting the `Content-Type: application/json` HTTP header.<br/>
        /// Note that if the object in the POST payload does not define a particular<br/>
        /// input property, the Actor run uses the default value defined by the task (or the Actor's<br/>
        /// input schema if not defined by the task).<br/>
        /// You can send all the same options in parameters as the [Get Dataset<br/>
        /// Items](#/reference/datasets/item-collection/get-items) API endpoint.<br/>
        /// Beware that it might be impossible to maintain an idle HTTP connection for<br/>
        /// an extended period, due to client timeout or network conditions. Make sure your HTTP client is<br/>
        /// configured to have a long enough connection timeout.<br/>
        /// If the connection breaks, you will not receive any information about the run<br/>
        /// and its status.<br/>
        /// Input fields from Actor task configuration can be overloaded with values<br/>
        /// passed as the POST payload.<br/>
        /// Just make sure to specify the `Content-Type` header as `application/json`<br/>
        /// and that the input is an object.<br/>
        /// To run the task asynchronously, use the [Run<br/>
        /// task](#/reference/actor-tasks/run-collection/run-task) API endpoint instead.
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
        /// <param name="webhooks">
        /// Example: dGhpcyBpcyBqdXN0IGV4YW1wbGUK...
        /// </param>
        /// <param name="format">
        /// Example: json
        /// </param>
        /// <param name="clean">
        /// Example: false
        /// </param>
        /// <param name="offset">
        /// Example: 0
        /// </param>
        /// <param name="limit"></param>
        /// <param name="fields">
        /// Example: myValue,myOtherValue
        /// </param>
        /// <param name="omit">
        /// Example: myValue,myOtherValue
        /// </param>
        /// <param name="unwind">
        /// Example: myValue,myOtherValue
        /// </param>
        /// <param name="flatten">
        /// Example: myValue
        /// </param>
        /// <param name="desc">
        /// Example: true
        /// </param>
        /// <param name="attachment">
        /// Example: true
        /// </param>
        /// <param name="delimiter">
        /// Example: ;
        /// </param>
        /// <param name="bom">
        /// Example: false
        /// </param>
        /// <param name="xmlRoot">
        /// Example: items
        /// </param>
        /// <param name="xmlRow">
        /// Example: item
        /// </param>
        /// <param name="skipHeaderRow">
        /// Example: true
        /// </param>
        /// <param name="skipHidden">
        /// Example: false
        /// </param>
        /// <param name="skipEmpty">
        /// Example: false
        /// </param>
        /// <param name="simplified">
        /// Example: false
        /// </param>
        /// <param name="skipFailedPages">
        /// Example: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ActorTaskRunSyncGetDatasetItemsPostAsync(
            string actorTaskId,
            double? timeout = default,
            double? memory = default,
            double? maxItems = default,
            double? maxTotalChargeUsd = default,
            bool? restartOnError = default,
            string? build = default,
            string? webhooks = default,
            string? format = default,
            bool? clean = default,
            double? offset = default,
            double? limit = default,
            string? fields = default,
            string? omit = default,
            string? unwind = default,
            string? flatten = default,
            bool? desc = default,
            bool? attachment = default,
            string? delimiter = default,
            bool? bom = default,
            string? xmlRoot = default,
            string? xmlRow = default,
            bool? skipHeaderRow = default,
            bool? skipHidden = default,
            bool? skipEmpty = default,
            bool? simplified = default,
            bool? skipFailedPages = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}