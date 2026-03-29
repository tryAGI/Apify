#nullable enable

namespace Apify
{
    public partial interface IActorTasksClient
    {
        /// <summary>
        /// Get list of task runs<br/>
        /// Get a list of runs of a specific task. The response is a list of objects,<br/>
        /// where each object contains essential information about a single task run.<br/>
        /// The endpoint supports pagination using the `limit` and `offset` parameters,<br/>
        /// and it does not return more than a 1000 array elements.<br/>
        /// By default, the records are sorted by the `startedAt` field in ascending<br/>
        /// order; therefore you can use pagination to incrementally fetch all records while<br/>
        /// new ones are still being created. To sort the records in descending order, use<br/>
        /// the `desc=1` parameter. You can also filter runs by status ([available<br/>
        /// statuses](https://docs.apify.com/platform/actors/running/runs-and-builds#lifecycle)).
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="offset">
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Example: 1000
        /// </param>
        /// <param name="desc">
        /// Example: true
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ActorTaskRunsGetResponse> ActorTaskRunsGetAsync(
            string actorTaskId,
            double? offset = default,
            double? limit = default,
            bool? desc = default,
            string? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}