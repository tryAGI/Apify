#nullable enable

namespace Apify
{
    public partial interface IActorTasksClient
    {
        /// <summary>
        /// Create task<br/>
        /// Create a new task with settings specified by the object passed as JSON in<br/>
        /// the POST payload.<br/>
        /// The response is the full task object as returned by the<br/>
        /// [Get task](#/reference/tasks/task-object/get-task) endpoint.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL. ([More<br/>
        /// info](#/introduction/authentication)).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.TaskResponse> ActorTasksPostAsync(

            global::Apify.AllOf<global::Apify.CreateTaskRequest, object> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create task<br/>
        /// Create a new task with settings specified by the object passed as JSON in<br/>
        /// the POST payload.<br/>
        /// The response is the full task object as returned by the<br/>
        /// [Get task](#/reference/tasks/task-object/get-task) endpoint.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL. ([More<br/>
        /// info](#/introduction/authentication)).
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.TaskResponse> ActorTasksPostAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}