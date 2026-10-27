#nullable enable

namespace Apify
{
    public partial interface IUsersUsageClient
    {
        /// <summary>
        /// Get user's monthly usage by ID<br/>
        /// Returns the same summary of monthly usage as [Get user's monthly usage](/api/v2/users-me-usage-monthly-get),<br/>
        /// for an account given by its ID or username.<br/>
        /// You can only access your own account, or the organization your API token belongs to. API tokens with<br/>
        /// limited permissions can't use this endpoint.<br/>
        /// Using the `date` parameter will show the usage in the monthly usage cycle that<br/>
        /// includes that date.
        /// </summary>
        /// <param name="userId">
        /// Example: HGzIk8z78YcAPEB
        /// </param>
        /// <param name="date">
        /// Example: 2020-06-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.MonthlyUsageResponse> UsersUsageMonthlyGetAsync(
            string userId,
            string? date = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get user's monthly usage by ID<br/>
        /// Returns the same summary of monthly usage as [Get user's monthly usage](/api/v2/users-me-usage-monthly-get),<br/>
        /// for an account given by its ID or username.<br/>
        /// You can only access your own account, or the organization your API token belongs to. API tokens with<br/>
        /// limited permissions can't use this endpoint.<br/>
        /// Using the `date` parameter will show the usage in the monthly usage cycle that<br/>
        /// includes that date.
        /// </summary>
        /// <param name="userId">
        /// Example: HGzIk8z78YcAPEB
        /// </param>
        /// <param name="date">
        /// Example: 2020-06-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.MonthlyUsageResponse>> UsersUsageMonthlyGetAsResponseAsync(
            string userId,
            string? date = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}