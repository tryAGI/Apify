#nullable enable

namespace Apify
{
    public partial interface IActorsClient
    {
        /// <summary>
        /// Get list of Actor OAuth connections<br/>
        /// Gets the OAuth connections configured on the Actor. Each connection defines an OAuth provider that users of the<br/>
        /// Actor can connect their accounts through. Only public credential fields are returned, never the client secret.<br/>
        /// An Actor has at most 5 connections, so the list is not paginated.<br/>
        /// You need read access to the Actor.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ListOfActorOAuthConnectionsResponse> ActorOauthConnectionsGetAsync(
            string actorId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get list of Actor OAuth connections<br/>
        /// Gets the OAuth connections configured on the Actor. Each connection defines an OAuth provider that users of the<br/>
        /// Actor can connect their accounts through. Only public credential fields are returned, never the client secret.<br/>
        /// An Actor has at most 5 connections, so the list is not paginated.<br/>
        /// You need read access to the Actor.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ListOfActorOAuthConnectionsResponse>> ActorOauthConnectionsGetAsResponseAsync(
            string actorId,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}