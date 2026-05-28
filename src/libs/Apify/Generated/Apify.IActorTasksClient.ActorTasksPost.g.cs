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
        /// [Get task](/api/v2/actor-task-get) endpoint.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.TaskResponse> ActorTasksPostAsync(

            global::Apify.AllOf<global::Apify.CreateTaskRequest, object> request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create task<br/>
        /// Create a new task with settings specified by the object passed as JSON in<br/>
        /// the POST payload.<br/>
        /// The response is the full task object as returned by the<br/>
        /// [Get task](/api/v2/actor-task-get) endpoint.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.TaskResponse>> ActorTasksPostAsResponseAsync(

            global::Apify.AllOf<global::Apify.CreateTaskRequest, object> request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create task<br/>
        /// Create a new task with settings specified by the object passed as JSON in<br/>
        /// the POST payload.<br/>
        /// The response is the full task object as returned by the<br/>
        /// [Get task](/api/v2/actor-task-get) endpoint.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.TaskResponse> ActorTasksPostAsync(
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}