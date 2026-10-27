#nullable enable

namespace Apify
{
    public partial interface IUsersUsageClient
    {
        /// <summary>
        /// Update user's limits by ID<br/>
        /// Updates the same limits as [Update user's limits](/api/v2/users-me-limits-put), for an account given by its ID<br/>
        /// or username.<br/>
        /// You can only access your own account, or the organization your API token belongs to. API tokens with<br/>
        /// limited permissions can't use this endpoint.<br/>
        /// For an organization, you also need the permission to manage the organization.
        /// </summary>
        /// <param name="userId">
        /// Example: HGzIk8z78YcAPEB
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UsersLimitsPutAsync(
            string userId,

            global::Apify.UpdateLimitsRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update user's limits by ID<br/>
        /// Updates the same limits as [Update user's limits](/api/v2/users-me-limits-put), for an account given by its ID<br/>
        /// or username.<br/>
        /// You can only access your own account, or the organization your API token belongs to. API tokens with<br/>
        /// limited permissions can't use this endpoint.<br/>
        /// For an organization, you also need the permission to manage the organization.
        /// </summary>
        /// <param name="userId">
        /// Example: HGzIk8z78YcAPEB
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<string>> UsersLimitsPutAsResponseAsync(
            string userId,

            global::Apify.UpdateLimitsRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update user's limits by ID<br/>
        /// Updates the same limits as [Update user's limits](/api/v2/users-me-limits-put), for an account given by its ID<br/>
        /// or username.<br/>
        /// You can only access your own account, or the organization your API token belongs to. API tokens with<br/>
        /// limited permissions can't use this endpoint.<br/>
        /// For an organization, you also need the permission to manage the organization.
        /// </summary>
        /// <param name="userId">
        /// Example: HGzIk8z78YcAPEB
        /// </param>
        /// <param name="maxMonthlyUsageUsd">
        /// If your platform usage in the billing period exceeds the prepaid usage, you will be charged extra. Setting this property you can update your hard limit on monthly platform usage to prevent accidental overage or to limit the extra charges.
        /// </param>
        /// <param name="dataRetentionDays">
        /// Apify securely stores your ten most recent Actor runs indefinitely, ensuring they are always accessible. Unnamed storages and other Actor runs are automatically deleted after the retention period. If you're subscribed, you can change it to keep data for longer or to limit your usage. [Lear more](https://docs.apify.com/storage#data-retention).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UsersLimitsPutAsync(
            string userId,
            double? maxMonthlyUsageUsd = default,
            int? dataRetentionDays = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}