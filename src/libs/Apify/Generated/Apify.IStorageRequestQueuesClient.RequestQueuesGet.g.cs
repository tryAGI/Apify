#nullable enable

namespace Apify
{
    public partial interface IStorageRequestQueuesClient
    {
        /// <summary>
        /// Get list of request queues<br/>
        /// Lists all of a user's request queues. The response is a JSON array of<br/>
        /// objects, where each object<br/>
        /// contains basic information about one queue.<br/>
        /// By default, the objects are sorted by the `createdAt` field in ascending order,<br/>
        /// therefore you can use pagination to incrementally fetch all queues while new<br/>
        /// ones are still being created. To sort them in descending order, use `desc=1`<br/>
        /// parameter. The endpoint supports pagination using `limit` and `offset`<br/>
        /// parameters and it will not return more than 1000<br/>
        /// array elements.
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
        /// <param name="unnamed">
        /// Example: true
        /// </param>
        /// <param name="ownership"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ListOfRequestQueuesResponse> RequestQueuesGetAsync(
            double? offset = default,
            double? limit = default,
            bool? desc = default,
            bool? unnamed = default,
            global::Apify.StorageOwnership? ownership = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}