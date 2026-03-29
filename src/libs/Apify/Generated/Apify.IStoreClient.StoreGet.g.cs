#nullable enable

namespace Apify
{
    public partial interface IStoreClient
    {
        /// <summary>
        /// Get list of Actors in store<br/>
        /// Gets the list of public Actors in Apify Store. You can use `search`<br/>
        /// parameter to search Actors by string in title, name, description, username<br/>
        /// and readme.<br/>
        /// If you need detailed info about a specific Actor, use the [Get<br/>
        /// Actor](#/reference/actors/actor-object/get-actor) endpoint.<br/>
        /// The endpoint supports pagination using the `limit` and `offset` parameters.<br/>
        /// It will not return more than 1,000 records.
        /// </summary>
        /// <param name="limit">
        /// Example: 1000
        /// </param>
        /// <param name="offset">
        /// Example: 0
        /// </param>
        /// <param name="search">
        /// Example: web scraper
        /// </param>
        /// <param name="sortBy">
        /// Example: 'popularity'
        /// </param>
        /// <param name="category">
        /// Example: 'AI'
        /// </param>
        /// <param name="username">
        /// Example: 'apify'
        /// </param>
        /// <param name="pricingModel">
        /// Example: FREE
        /// </param>
        /// <param name="allowsAgenticUsers">
        /// Example: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ListOfActorsInStoreResponse> StoreGetAsync(
            double? limit = default,
            double? offset = default,
            string? search = default,
            string? sortBy = default,
            string? category = default,
            string? username = default,
            global::Apify.StoreGetPricingModel? pricingModel = default,
            bool? allowsAgenticUsers = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}