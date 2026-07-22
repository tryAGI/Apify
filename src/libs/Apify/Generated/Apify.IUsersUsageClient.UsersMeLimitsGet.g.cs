#nullable enable

namespace Apify
{
    public partial interface IUsersUsageClient
    {
        /// <summary>
        /// Get limits<br/>
        /// Returns a complete summary of your account's limits. It is the same<br/>
        /// information you will see on your account's [Limits page](https://console.apify.com/billing#/limits). The returned data<br/>
        /// includes the current usage cycle, a summary of your limits, and your current usage.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.LimitsResponse> UsersMeLimitsGetAsync(
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get limits<br/>
        /// Returns a complete summary of your account's limits. It is the same<br/>
        /// information you will see on your account's [Limits page](https://console.apify.com/billing#/limits). The returned data<br/>
        /// includes the current usage cycle, a summary of your limits, and your current usage.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.LimitsResponse>> UsersMeLimitsGetAsResponseAsync(
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}