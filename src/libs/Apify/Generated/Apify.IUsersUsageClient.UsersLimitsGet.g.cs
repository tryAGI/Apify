#nullable enable

namespace Apify
{
    public partial interface IUsersUsageClient
    {
        /// <summary>
        /// Get user's limits by ID<br/>
        /// Returns the same summary of limits as [Get user's limits](/api/v2/users-me-limits-get), for an account given by<br/>
        /// its ID or username.<br/>
        /// You can only access your own account, or the organization your API token belongs to. API tokens with<br/>
        /// limited permissions can't use this endpoint.
        /// </summary>
        /// <param name="userId">
        /// Example: HGzIk8z78YcAPEB
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AccountLimitsResponse> UsersLimitsGetAsync(
            string userId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get user's limits by ID<br/>
        /// Returns the same summary of limits as [Get user's limits](/api/v2/users-me-limits-get), for an account given by<br/>
        /// its ID or username.<br/>
        /// You can only access your own account, or the organization your API token belongs to. API tokens with<br/>
        /// limited permissions can't use this endpoint.
        /// </summary>
        /// <param name="userId">
        /// Example: HGzIk8z78YcAPEB
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.AccountLimitsResponse>> UsersLimitsGetAsResponseAsync(
            string userId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}