#nullable enable

namespace Apify
{
    public partial interface IActorsActorVersionsClient
    {
        /// <summary>
        /// Update Actor version build on push<br/>
        /// Turns automatic builds on push on or off for an Actor version whose source is a git repository.<br/>
        /// Enabling registers a push webhook on the repository through the connected git account given by `providerId`, so<br/>
        /// that every push to the repository builds the version. Disabling turns the webhook off on GitHub, or removes it<br/>
        /// on GitLab and Bitbucket.<br/>
        /// You need write access to the Actor. The version must have its source type set to a git repository, and the<br/>
        /// connected account must have permission to manage the repository's webhooks.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="versionNumber">
        /// Example: 0.1
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task ActorVersionBuildOnPushPutAsync(
            string actorId,
            string versionNumber,

            global::Apify.UpdateBuildOnPushRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Actor version build on push<br/>
        /// Turns automatic builds on push on or off for an Actor version whose source is a git repository.<br/>
        /// Enabling registers a push webhook on the repository through the connected git account given by `providerId`, so<br/>
        /// that every push to the repository builds the version. Disabling turns the webhook off on GitHub, or removes it<br/>
        /// on GitLab and Bitbucket.<br/>
        /// You need write access to the Actor. The version must have its source type set to a git repository, and the<br/>
        /// connected account must have permission to manage the repository's webhooks.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="versionNumber">
        /// Example: 0.1
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse> ActorVersionBuildOnPushPutAsResponseAsync(
            string actorId,
            string versionNumber,

            global::Apify.UpdateBuildOnPushRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Actor version build on push<br/>
        /// Turns automatic builds on push on or off for an Actor version whose source is a git repository.<br/>
        /// Enabling registers a push webhook on the repository through the connected git account given by `providerId`, so<br/>
        /// that every push to the repository builds the version. Disabling turns the webhook off on GitHub, or removes it<br/>
        /// on GitLab and Bitbucket.<br/>
        /// You need write access to the Actor. The version must have its source type set to a git repository, and the<br/>
        /// connected account must have permission to manage the repository's webhooks.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
        /// </param>
        /// <param name="versionNumber">
        /// Example: 0.1
        /// </param>
        /// <param name="providerId">
        /// The connected git account to register the push webhook through: `github-app` for the GitHub App, or the ID<br/>
        /// of a connected GitLab or Bitbucket integration, as returned by the [Get git provider integrations](/api/v2/integrations-git-get) endpoint.
        /// </param>
        /// <param name="enabled">
        /// `true` registers the push webhook so that pushes to the repository build the version; `false` turns it off.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActorVersionBuildOnPushPutAsync(
            string actorId,
            string versionNumber,
            string providerId,
            bool enabled,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}