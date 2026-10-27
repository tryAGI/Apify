#nullable enable

namespace Apify
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Register deployment key<br/>
        /// Registers the Actor's deployment key (a read-only SSH key generated for every Actor) on a repository through a<br/>
        /// connected git account, so that Apify can clone the repository when building the Actor.<br/>
        /// You need write access to the Actor. The repository's host must match the provider of the connected account.<br/>
        /// If the key is already registered on the repository, nothing changes. On GitHub, registering the key on another<br/>
        /// repository removes it from the previously linked one.
        /// </summary>
        /// <param name="providerId">
        /// Example: github-app
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.RegisterDeploymentKeyResponse> IntegrationsGitRegisterDeploymentKeyPostAsync(
            string providerId,

            global::Apify.RegisterDeploymentKeyRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register deployment key<br/>
        /// Registers the Actor's deployment key (a read-only SSH key generated for every Actor) on a repository through a<br/>
        /// connected git account, so that Apify can clone the repository when building the Actor.<br/>
        /// You need write access to the Actor. The repository's host must match the provider of the connected account.<br/>
        /// If the key is already registered on the repository, nothing changes. On GitHub, registering the key on another<br/>
        /// repository removes it from the previously linked one.
        /// </summary>
        /// <param name="providerId">
        /// Example: github-app
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.RegisterDeploymentKeyResponse>> IntegrationsGitRegisterDeploymentKeyPostAsResponseAsync(
            string providerId,

            global::Apify.RegisterDeploymentKeyRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register deployment key<br/>
        /// Registers the Actor's deployment key (a read-only SSH key generated for every Actor) on a repository through a<br/>
        /// connected git account, so that Apify can clone the repository when building the Actor.<br/>
        /// You need write access to the Actor. The repository's host must match the provider of the connected account.<br/>
        /// If the key is already registered on the repository, nothing changes. On GitHub, registering the key on another<br/>
        /// repository removes it from the previously linked one.
        /// </summary>
        /// <param name="providerId">
        /// Example: github-app
        /// </param>
        /// <param name="actorId">
        /// ID or `username~name` of the Actor whose deployment key to register.
        /// </param>
        /// <param name="repoName">
        /// URL of the repository to register the key on. Its host must match the provider.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.RegisterDeploymentKeyResponse> IntegrationsGitRegisterDeploymentKeyPostAsync(
            string providerId,
            string actorId,
            string repoName,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}