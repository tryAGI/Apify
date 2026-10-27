#nullable enable

namespace Apify
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Create git repository<br/>
        /// Creates a repository through a connected git account and commits the initial files into it, either the given<br/>
        /// `files` or the files of an Actor template archive (`templateArchiveUrl`).
        /// </summary>
        /// <param name="providerId">
        /// Example: github-app
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.GitRepoResponse> IntegrationsGitCreateRepoPostAsync(
            string providerId,

            global::Apify.CreateGitRepoRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create git repository<br/>
        /// Creates a repository through a connected git account and commits the initial files into it, either the given<br/>
        /// `files` or the files of an Actor template archive (`templateArchiveUrl`).
        /// </summary>
        /// <param name="providerId">
        /// Example: github-app
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.GitRepoResponse>> IntegrationsGitCreateRepoPostAsResponseAsync(
            string providerId,

            global::Apify.CreateGitRepoRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create git repository<br/>
        /// Creates a repository through a connected git account and commits the initial files into it, either the given<br/>
        /// `files` or the files of an Actor template archive (`templateArchiveUrl`).
        /// </summary>
        /// <param name="providerId">
        /// Example: github-app
        /// </param>
        /// <param name="workspace">
        /// Where to create the repository, as the `id` of one of the provider's workspaces. On GitLab, this is the<br/>
        /// numeric namespace ID.
        /// </param>
        /// <param name="repoName"></param>
        /// <param name="isPrivate"></param>
        /// <param name="files">
        /// Files to commit as the initial commit. Can't be combined with `templateArchiveUrl`.
        /// </param>
        /// <param name="templateArchiveUrl">
        /// URL of an Actor template archive whose files are committed as the initial commit. Can't be combined with<br/>
        /// `files`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.GitRepoResponse> IntegrationsGitCreateRepoPostAsync(
            string providerId,
            string workspace,
            string repoName,
            bool isPrivate,
            global::System.Collections.Generic.IList<global::Apify.GitRepoFile>? files = default,
            string? templateArchiveUrl = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}