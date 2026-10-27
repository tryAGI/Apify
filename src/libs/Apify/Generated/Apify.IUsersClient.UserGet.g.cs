#nullable enable

namespace Apify
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get public user data<br/>
        /// Returns public information about a specific user account, similar to what<br/>
        /// can be seen on public profile pages (e.g. https://apify.com/apify).<br/>
        /// This operation requires no authentication token.<br/>
        /// When the request is authenticated with an API token of the requested user account, or with a token<br/>
        /// that impersonates it, the response also contains the private information, the same as in<br/>
        /// [Get private user data](/api/v2/users-me-get). Tokens with limited permissions never receive it.
        /// </summary>
        /// <param name="userId">
        /// Example: HGzIk8z78YcAPEB
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AnyOf<global::Apify.UserPublicInfoResponse, global::Apify.UserPrivateInfoResponse>> UserGetAsync(
            string userId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get public user data<br/>
        /// Returns public information about a specific user account, similar to what<br/>
        /// can be seen on public profile pages (e.g. https://apify.com/apify).<br/>
        /// This operation requires no authentication token.<br/>
        /// When the request is authenticated with an API token of the requested user account, or with a token<br/>
        /// that impersonates it, the response also contains the private information, the same as in<br/>
        /// [Get private user data](/api/v2/users-me-get). Tokens with limited permissions never receive it.
        /// </summary>
        /// <param name="userId">
        /// Example: HGzIk8z78YcAPEB
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.AnyOf<global::Apify.UserPublicInfoResponse, global::Apify.UserPrivateInfoResponse>>> UserGetAsResponseAsync(
            string userId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}