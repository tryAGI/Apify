#nullable enable

namespace Apify
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get git provider integrations<br/>
        /// Gets your connected git provider accounts (GitHub App, GitLab and Bitbucket), each with the workspaces you can<br/>
        /// create a repository in. Only authorized accounts are returned, and accounts whose access was revoked are left<br/>
        /// out.<br/>
        /// Use the `id` of an integration as the `providerId` in the<br/>
        /// [Create git repository](/api/v2/integrations-git-create-repo-post) and<br/>
        /// [Register deployment key](/api/v2/integrations-git-register-deployment-key-post) endpoints.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ListOfGitProviderIntegrationsResponse> IntegrationsGitGetAsync(
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get git provider integrations<br/>
        /// Gets your connected git provider accounts (GitHub App, GitLab and Bitbucket), each with the workspaces you can<br/>
        /// create a repository in. Only authorized accounts are returned, and accounts whose access was revoked are left<br/>
        /// out.<br/>
        /// Use the `id` of an integration as the `providerId` in the<br/>
        /// [Create git repository](/api/v2/integrations-git-create-repo-post) and<br/>
        /// [Register deployment key](/api/v2/integrations-git-register-deployment-key-post) endpoints.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.ListOfGitProviderIntegrationsResponse>> IntegrationsGitGetAsResponseAsync(
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}