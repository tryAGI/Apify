#nullable enable

namespace Apify
{
    public partial interface IActorTasksClient
    {
        /// <summary>
        /// Update task input<br/>
        /// Updates the input of a task using values specified by an object passed as<br/>
        /// JSON in the PUT payload.<br/>
        /// If the object does not define a specific property, its value is not updated.<br/>
        /// The response is the full task input as returned by the<br/>
        /// [Get task input](#/reference/tasks/task-input-object/get-task-input) endpoint.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP<br/>
        /// header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL. ([More<br/>
        /// info](#/introduction/authentication)).
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ActorTaskInputPutAsync(
            string actorTaskId,

            object request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update task input<br/>
        /// Updates the input of a task using values specified by an object passed as<br/>
        /// JSON in the PUT payload.<br/>
        /// If the object does not define a specific property, its value is not updated.<br/>
        /// The response is the full task input as returned by the<br/>
        /// [Get task input](#/reference/tasks/task-input-object/get-task-input) endpoint.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP<br/>
        /// header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL. ([More<br/>
        /// info](#/introduction/authentication)).
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<string>> ActorTaskInputPutAsResponseAsync(
            string actorTaskId,

            object request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update task input<br/>
        /// Updates the input of a task using values specified by an object passed as<br/>
        /// JSON in the PUT payload.<br/>
        /// If the object does not define a specific property, its value is not updated.<br/>
        /// The response is the full task input as returned by the<br/>
        /// [Get task input](#/reference/tasks/task-input-object/get-task-input) endpoint.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP<br/>
        /// header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL. ([More<br/>
        /// info](#/introduction/authentication)).
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ActorTaskInputPutAsync(
            string actorTaskId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}