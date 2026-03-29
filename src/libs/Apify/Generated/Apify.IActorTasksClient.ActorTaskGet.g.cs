#nullable enable

namespace Apify
{
    public partial interface IActorTasksClient
    {
        /// <summary>
        /// Get task<br/>
        /// Get an object that contains all the details about a task.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ActorTaskGetResponse> ActorTaskGetAsync(
            string actorTaskId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}