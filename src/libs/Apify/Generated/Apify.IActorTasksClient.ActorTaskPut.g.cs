#nullable enable

namespace Apify
{
    public partial interface IActorTasksClient
    {
        /// <summary>
        /// Update task<br/>
        /// Update settings of a task using values specified by an object passed as JSON<br/>
        /// in the POST payload.<br/>
        /// If the object does not define a specific property, its value is not updated.<br/>
        /// The `publicConfig` field carries the display configuration of the task's public<br/>
        /// landing page, and `isPublic` publishes or unpublishes the task itself. Both require<br/>
        /// write permission to the task's Actor.<br/>
        /// To publish a task, its Actor must be public, `publicConfig.inputSchemaFields` and<br/>
        /// `publicConfig.datasetView` must be set, and the Actor must have fewer than 50 published<br/>
        /// tasks. If the task isn't ready to be published, the whole update fails and none of it<br/>
        /// is applied.<br/>
        /// Publishing lists the task among the Actor's examples and makes its input public, so anyone<br/>
        /// can view and copy it. The landing page itself is shown only while `publicConfig` still<br/>
        /// validates against the Actor's current build, so a new build can stop the page from being<br/>
        /// offered while the task stays published and copyable.<br/>
        /// The response is the full task object as returned by the<br/>
        /// [Get task](/api/v2/actor-task-get) endpoint.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP<br/>
        /// header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ActorTaskPutResponse> ActorTaskPutAsync(
            string actorTaskId,

            global::Apify.UpdateTaskRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update task<br/>
        /// Update settings of a task using values specified by an object passed as JSON<br/>
        /// in the POST payload.<br/>
        /// If the object does not define a specific property, its value is not updated.<br/>
        /// The `publicConfig` field carries the display configuration of the task's public<br/>
        /// landing page, and `isPublic` publishes or unpublishes the task itself. Both require<br/>
        /// write permission to the task's Actor.<br/>
        /// To publish a task, its Actor must be public, `publicConfig.inputSchemaFields` and<br/>
        /// `publicConfig.datasetView` must be set, and the Actor must have fewer than 50 published<br/>
        /// tasks. If the task isn't ready to be published, the whole update fails and none of it<br/>
        /// is applied.<br/>
        /// Publishing lists the task among the Actor's examples and makes its input public, so anyone<br/>
        /// can view and copy it. The landing page itself is shown only while `publicConfig` still<br/>
        /// validates against the Actor's current build, so a new build can stop the page from being<br/>
        /// offered while the task stays published and copyable.<br/>
        /// The response is the full task object as returned by the<br/>
        /// [Get task](/api/v2/actor-task-get) endpoint.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP<br/>
        /// header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ActorTaskPutResponse>> ActorTaskPutAsResponseAsync(
            string actorTaskId,

            global::Apify.UpdateTaskRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update task<br/>
        /// Update settings of a task using values specified by an object passed as JSON<br/>
        /// in the POST payload.<br/>
        /// If the object does not define a specific property, its value is not updated.<br/>
        /// The `publicConfig` field carries the display configuration of the task's public<br/>
        /// landing page, and `isPublic` publishes or unpublishes the task itself. Both require<br/>
        /// write permission to the task's Actor.<br/>
        /// To publish a task, its Actor must be public, `publicConfig.inputSchemaFields` and<br/>
        /// `publicConfig.datasetView` must be set, and the Actor must have fewer than 50 published<br/>
        /// tasks. If the task isn't ready to be published, the whole update fails and none of it<br/>
        /// is applied.<br/>
        /// Publishing lists the task among the Actor's examples and makes its input public, so anyone<br/>
        /// can view and copy it. The landing page itself is shown only while `publicConfig` still<br/>
        /// validates against the Actor's current build, so a new build can stop the page from being<br/>
        /// offered while the task stays published and copyable.<br/>
        /// The response is the full task object as returned by the<br/>
        /// [Get task](/api/v2/actor-task-get) endpoint.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP<br/>
        /// header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="name"></param>
        /// <param name="options"></param>
        /// <param name="input"></param>
        /// <param name="title"></param>
        /// <param name="actorStandby"></param>
        /// <param name="publicConfig">
        /// Configuration that controls how the published task appears on its public landing page.<br/>
        /// Editing this object requires write permission to the Actor that the task belongs to.<br/>
        /// The fields you send are merged into the stored configuration, so you only need to include<br/>
        /// the ones you're changing. To clear a field, set it to `null`. Sending `publicConfig: null`<br/>
        /// is rejected, so the object as a whole can't be cleared.
        /// </param>
        /// <param name="isPublic">
        /// Set to `true` to publish the task on its public landing page, or `false` to unpublish it.<br/>
        /// Sending the value the task already has does nothing.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ActorTaskPutResponse> ActorTaskPutAsync(
            string actorTaskId,
            string? name = default,
            global::Apify.TaskOptions? options = default,
            global::Apify.TaskInput? input = default,
            string? title = default,
            global::Apify.ActorStandby? actorStandby = default,
            global::Apify.TaskPublicConfig? publicConfig = default,
            bool? isPublic = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}