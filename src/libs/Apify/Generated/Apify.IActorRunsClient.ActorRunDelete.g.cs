#nullable enable

namespace Apify
{
    public partial interface IActorRunsClient
    {
        /// <summary>
        /// Delete run<br/>
        /// Delete the run. Only finished runs can be deleted. Only the person or<br/>
        /// organization that initiated the run can delete it.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task ActorRunDeleteAsync(
            string runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}