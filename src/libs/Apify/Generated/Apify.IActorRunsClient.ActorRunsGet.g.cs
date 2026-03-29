#nullable enable

namespace Apify
{
    public partial interface IActorRunsClient
    {
        /// <summary>
        /// Get user runs list<br/>
        /// Gets a list of all runs for a user. The response is a list of objects, where<br/>
        /// each object contains basic information about a single Actor run.<br/>
        /// The endpoint supports pagination using the `limit` and `offset` parameters<br/>
        /// and it will not return more than 1000 array elements.<br/>
        /// By default, the records are sorted by the `startedAt` field in ascending<br/>
        /// order. Therefore, you can use pagination to incrementally fetch all records while<br/>
        /// new ones are still being created. To sort the records in descending order, use<br/>
        /// `desc=1` parameter. You can also filter runs by `startedAt`` and `status`` fields ([available<br/>
        /// statuses](https://docs.apify.com/platform/actors/running/runs-and-builds#lifecycle)).
        /// </summary>
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
        /// <param name="startedAfter">
        /// Example: 2025-09-01T00:00:00.000Z
        /// </param>
        /// <param name="startedBefore">
        /// Example: 2025-09-17T23:59:59.000Z
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ListOfRunsResponse> ActorRunsGetAsync(
            double? offset = default,
            double? limit = default,
            bool? desc = default,
            string? status = default,
            global::System.DateTime? startedAfter = default,
            global::System.DateTime? startedBefore = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}