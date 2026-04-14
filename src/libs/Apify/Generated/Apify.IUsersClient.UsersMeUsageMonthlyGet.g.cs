#nullable enable

namespace Apify
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get monthly usage<br/>
        /// Returns a complete summary of your usage for the current monthly usage cycle,<br/>
        /// an overall sum, as well as a daily breakdown of usage. It is the same<br/>
        /// information you will see on your account's [Billing &gt; Historical usage page](https://console.apify.com/billing/historical-usage). The information<br/>
        /// includes your use of Actors, compute, data transfer, and storage.<br/>
        /// Using the `date` parameter will show your usage in the monthly usage cycle that<br/>
        /// includes that date.
        /// </summary>
        /// <param name="date">
        /// Example: 2020-06-14
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.MonthlyUsageResponse> UsersMeUsageMonthlyGetAsync(
            string? date = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}