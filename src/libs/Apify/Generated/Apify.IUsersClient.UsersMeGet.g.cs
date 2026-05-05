#nullable enable

namespace Apify
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get private user data<br/>
        /// Returns information about the current user account, including both public<br/>
        /// and private information.<br/>
        /// The user account is identified by the provided authentication token.<br/>
        /// The fields `plan`, `email` and `profile` are omitted when this endpoint is accessed from Actor run.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.PrivateUserDataResponse> UsersMeGetAsync(
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get private user data<br/>
        /// Returns information about the current user account, including both public<br/>
        /// and private information.<br/>
        /// The user account is identified by the provided authentication token.<br/>
        /// The fields `plan`, `email` and `profile` are omitted when this endpoint is accessed from Actor run.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.PrivateUserDataResponse>> UsersMeGetAsResponseAsync(
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}