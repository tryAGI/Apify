#nullable enable

namespace Apify
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Get browser info<br/>
        /// Returns information about the HTTP request, including the client IP address,<br/>
        /// country code, request headers, and body length.<br/>
        /// This endpoint is designed for proxy testing. It accepts any HTTP method so you<br/>
        /// can verify that your proxy correctly forwards requests of any type and that<br/>
        /// client IP addresses are anonymized.
        /// </summary>
        /// <param name="skipHeaders"></param>
        /// <param name="rawHeaders"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.BrowserInfoResponse> ToolsBrowserInfoPutAsync(
            bool? skipHeaders = default,
            bool? rawHeaders = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}