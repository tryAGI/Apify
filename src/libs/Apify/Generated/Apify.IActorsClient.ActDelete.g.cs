#nullable enable

namespace Apify
{
    public partial interface IActorsClient
    {
        /// <summary>
        /// Delete Actor<br/>
        /// Deletes an Actor.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ActDeleteAsync(
            string actorId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}