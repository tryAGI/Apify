#nullable enable

namespace Apify
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get public user data<br/>
        /// Returns public information about a specific user account, similar to what<br/>
        /// can be seen on public profile pages (e.g. https://apify.com/apify).<br/>
        /// This operation requires no authentication token.
        /// </summary>
        /// <param name="userId">
        /// Example: HGzIk8z78YcAPEB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.PublicUserDataResponse> UserGetAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}