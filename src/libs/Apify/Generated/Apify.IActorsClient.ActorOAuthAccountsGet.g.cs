#nullable enable

namespace Apify
{
    public partial interface IActorsClient
    {
        /// <summary>
        /// Get list of Actor OAuth accounts<br/>
        /// Gets the accounts you connected through the Actor OAuth connection, including their OAuth tokens. Only accounts<br/>
        /// that finished authorization are returned.<br/>
        /// There are at most 5 accounts per user and connection, so the list is not paginated.
        /// </summary>
        /// <param name="connectionId">
        /// Example: kD9fm2Xp4cJq7Lw8N
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ListOfActorOAuthAccountsResponse> ActorOAuthAccountsGetAsync(
            string connectionId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get list of Actor OAuth accounts<br/>
        /// Gets the accounts you connected through the Actor OAuth connection, including their OAuth tokens. Only accounts<br/>
        /// that finished authorization are returned.<br/>
        /// There are at most 5 accounts per user and connection, so the list is not paginated.
        /// </summary>
        /// <param name="connectionId">
        /// Example: kD9fm2Xp4cJq7Lw8N
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ListOfActorOAuthAccountsResponse>> ActorOAuthAccountsGetAsResponseAsync(
            string connectionId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}