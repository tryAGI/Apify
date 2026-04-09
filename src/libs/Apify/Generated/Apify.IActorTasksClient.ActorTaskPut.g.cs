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
        /// The response is the full task object as returned by the<br/>
        /// [Get task](#/reference/tasks/task-object/get-task) endpoint.<br/>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ActorTaskPutResponse> ActorTaskPutAsync(
            string actorTaskId,

            global::Apify.UpdateTaskRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update task<br/>
        /// Update settings of a task using values specified by an object passed as JSON<br/>
        /// in the POST payload.<br/>
        /// If the object does not define a specific property, its value is not updated.<br/>
        /// The response is the full task object as returned by the<br/>
        /// [Get task](#/reference/tasks/task-object/get-task) endpoint.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP<br/>
        /// header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL. ([More<br/>
        /// info](#/introduction/authentication)).
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="name"></param>
        /// <param name="options"></param>
        /// <param name="input"></param>
        /// <param name="title"></param>
        /// <param name="actorStandby"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ActorTaskPutResponse> ActorTaskPutAsync(
            string actorTaskId,
            string? name = default,
            global::Apify.TaskOptions? options = default,
            global::Apify.TaskInput? input = default,
            string? title = default,
            global::Apify.ActorStandby? actorStandby = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}