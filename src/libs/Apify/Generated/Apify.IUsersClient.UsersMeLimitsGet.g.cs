#nullable enable

namespace Apify
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get limits<br/>
        /// Returns a complete summary of your account's limits. It is the same<br/>
        /// information you will see on your account's [Limits page](https://console.apify.com/billing#/limits). The returned data<br/>
        /// includes the current usage cycle, a summary of your limits, and your current usage.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.LimitsResponse> UsersMeLimitsGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}