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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.PrivateUserDataResponse> UsersMeGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}