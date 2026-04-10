#nullable enable

namespace Apify
{
    public partial interface IActorsActorVersionsClient
    {
        /// <summary>
        /// Update version (POST)<br/>
        /// Updates Actor version using values specified by a [Version object](#/reference/actors/version-object) passed as JSON in the POST payload.<br/>
        /// This endpoint is an alias for the [`PUT` update version](#tag/ActorsVersion-object/operation/act_version_put) method and behaves identically.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="versionNumber">
        /// Example: 0.1
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.VersionResponse> ActVersionPostAsync(
            string actorId,
            string versionNumber,

            global::Apify.CreateOrUpdateVersionRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update version (POST)<br/>
        /// Updates Actor version using values specified by a [Version object](#/reference/actors/version-object) passed as JSON in the POST payload.<br/>
        /// This endpoint is an alias for the [`PUT` update version](#tag/ActorsVersion-object/operation/act_version_put) method and behaves identically.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="versionNumber">
        /// Example: 0.1
        /// </param>
        /// <param name="requestVersionNumber"></param>
        /// <param name="sourceType"></param>
        /// <param name="envVars"></param>
        /// <param name="applyEnvVarsToBuild"></param>
        /// <param name="buildTag"></param>
        /// <param name="sourceFiles"></param>
        /// <param name="gitRepoUrl">
        /// URL of the Git repository when sourceType is GIT_REPO.
        /// </param>
        /// <param name="tarballUrl">
        /// URL of the tarball when sourceType is TARBALL.
        /// </param>
        /// <param name="gitHubGistUrl">
        /// URL of the GitHub Gist when sourceType is GITHUB_GIST.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.VersionResponse> ActVersionPostAsync(
            string actorId,
            string versionNumber,
            string? requestVersionNumber = default,
            global::Apify.VersionSourceType? sourceType = default,
            global::System.Collections.Generic.IList<global::Apify.EnvVarRequest>? envVars = default,
            bool? applyEnvVarsToBuild = default,
            string? buildTag = default,
            global::System.Collections.Generic.IList<global::Apify.AnyOf<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>>? sourceFiles = default,
            string? gitRepoUrl = default,
            string? tarballUrl = default,
            string? gitHubGistUrl = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}