#nullable enable

namespace Apify
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Update limits<br/>
        /// Updates the account's limits manageable on your account's [Limits page](https://console.apify.com/billing#/limits).<br/>
        /// Specifically the: `maxMonthlyUsageUsd` and `dataRetentionDays` limits (see request body schema for more details).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UsersMeLimitsPutAsync(

            global::Apify.UpdateLimitsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update limits<br/>
        /// Updates the account's limits manageable on your account's [Limits page](https://console.apify.com/billing#/limits).<br/>
        /// Specifically the: `maxMonthlyUsageUsd` and `dataRetentionDays` limits (see request body schema for more details).
        /// </summary>
        /// <param name="maxMonthlyUsageUsd">
        /// If your platform usage in the billing period exceeds the prepaid usage, you will be charged extra. Setting this property you can update your hard limit on monthly platform usage to prevent accidental overage or to limit the extra charges.
        /// </param>
        /// <param name="dataRetentionDays">
        /// Apify securely stores your ten most recent Actor runs indefinitely, ensuring they are always accessible. Unnamed storages and other Actor runs are automatically deleted after the retention period. If you're subscribed, you can change it to keep data for longer or to limit your usage. [Lear more](https://docs.apify.com/platform/storage/usage#data-retention).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UsersMeLimitsPutAsync(
            double? maxMonthlyUsageUsd = default,
            int? dataRetentionDays = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}