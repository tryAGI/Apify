#nullable enable

namespace Apify
{
    public partial interface IActorTasksClient
    {
        /// <summary>
        /// Delete task<br/>
        /// Delete the task specified through the `actorTaskId` parameter.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ActorTaskDeleteAsync(
            string actorTaskId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}