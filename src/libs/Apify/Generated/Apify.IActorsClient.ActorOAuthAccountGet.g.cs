#nullable enable

namespace Apify
{
    public partial interface IActorsClient
    {
        /// <summary>
        /// Get Actor OAuth account<br/>
        /// Gets an account connected through an Actor OAuth connection, including its OAuth tokens.<br/>
        /// This endpoint only accepts the API token of an Actor run (the `APIFY_TOKEN` environment variable of the run).<br/>
        /// The run must belong to the Actor that the account's OAuth connection is configured on, and the account must<br/>
        /// belong to the user the run's token acts for. Any other token gets a `403` error.
        /// </summary>
        /// <param name="accountId">
        /// Example: Rk3mP8xQ2vN5tY7wZ
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ActorOAuthAccountResponse> ActorOAuthAccountGetAsync(
            string accountId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Actor OAuth account<br/>
        /// Gets an account connected through an Actor OAuth connection, including its OAuth tokens.<br/>
        /// This endpoint only accepts the API token of an Actor run (the `APIFY_TOKEN` environment variable of the run).<br/>
        /// The run must belong to the Actor that the account's OAuth connection is configured on, and the account must<br/>
        /// belong to the user the run's token acts for. Any other token gets a `403` error.
        /// </summary>
        /// <param name="accountId">
        /// Example: Rk3mP8xQ2vN5tY7wZ
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ActorOAuthAccountResponse>> ActorOAuthAccountGetAsResponseAsync(
            string accountId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}