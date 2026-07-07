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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.VersionResponse>> ActVersionPostAsResponseAsync(
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
        /// <param name="requestVersionNumber">
        /// The version number of the Actor. Two numbers separated by a dot, that represent the `MAJOR.MINOR` part of the semantic versioning.
        /// </param>
        /// <param name="sourceType">
        /// Where the source code of the version lives.
        /// </param>
        /// <param name="envVars">
        /// Environment variables for the version.
        /// </param>
        /// <param name="applyEnvVarsToBuild">
        /// Whether to inject the environment variables at build time.
        /// </param>
        /// <param name="buildTag">
        /// The tag name to apply to a successful build of this version. Can be `null` when the version has no build tag.
        /// </param>
        /// <param name="sourceFiles">
        /// Applies when the `sourceType` is `SOURCE_FILES`. Represents the Actor's file structure as an array of files and folders.
        /// </param>
        /// <param name="gitRepoUrl">
        /// URL of the Git repository to clone the source code from. Applies when the `sourceType` is `GIT_REPO`.
        /// </param>
        /// <param name="tarballUrl">
        /// URL of the tarball to download the source code from. Applies when the `sourceType` is `TARBALL`.
        /// </param>
        /// <param name="gitHubGistUrl">
        /// URL of the GitHub Gist to clone the source code from. Applies when the `sourceType` is `GITHUB_GIST`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.VersionResponse> ActVersionPostAsync(
            string actorId,
            string versionNumber,
            string? requestVersionNumber = default,
            global::Apify.VersionSourceType? sourceType = default,
            global::System.Collections.Generic.IList<global::Apify.EnvVar>? envVars = default,
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