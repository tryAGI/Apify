#nullable enable

namespace Apify
{
    public partial interface IActorsActorVersionsClient
    {
        /// <summary>
        /// Update Actor version (POST)<br/>
        /// Updates Actor version using values specified by a `Version` object passed as JSON in the POST payload.<br/>
        /// This endpoint is an alias for the [Update Actor version](/api/v2/actor-version-put) endpoint and behaves identically.
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
        global::System.Threading.Tasks.Task<global::Apify.VersionResponse> ActorVersionPostAsync(
            string actorId,
            string versionNumber,

            global::Apify.UpdateVersionRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Actor version (POST)<br/>
        /// Updates Actor version using values specified by a `Version` object passed as JSON in the POST payload.<br/>
        /// This endpoint is an alias for the [Update Actor version](/api/v2/actor-version-put) endpoint and behaves identically.
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
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.VersionResponse>> ActorVersionPostAsResponseAsync(
            string actorId,
            string versionNumber,

            global::Apify.UpdateVersionRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Actor version (POST)<br/>
        /// Updates Actor version using values specified by a `Version` object passed as JSON in the POST payload.<br/>
        /// This endpoint is an alias for the [Update Actor version](/api/v2/actor-version-put) endpoint and behaves identically.
        /// </summary>
        /// <param name="actorId">
        /// Example: compass~google-maps-extractor
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
        /// URL of the zip archive to download the source code from. Applies when the `sourceType` is `TARBALL`.
        /// </param>
        /// <param name="gitHubGistUrl">
        /// URL of the GitHub Gist to clone the source code from. Applies when the `sourceType` is `GITHUB_GIST`.
        /// </param>
        /// <param name="actorPath">
        /// The Actor's directory inside the uploaded source, as a path relative to the upload root with `/` separators, for example `actors/typescript-actor`. Applies when the `sourceType` is `SOURCE_FILES` or `TARBALL`. The API rejects it when the `sourceType` is `GIT_REPO` or `GITHUB_GIST`. On an update without `sourceType`, the API checks it against the version's stored source type. When the version has no `actorPath`, the upload root is the Actor's directory. It has 1 to 255 characters, with no leading, trailing, or repeated `/` and no `.` or `..` segments. An update that sends `sourceType`, `sourceFiles`, or `tarballUrl` without `actorPath` removes the stored `actorPath`, so send it again with every upload. An update of other fields, such as `envVars` or `buildTag`, keeps it. Send `null` to remove it.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.VersionResponse> ActorVersionPostAsync(
            string actorId,
            string versionNumber,
            string? requestVersionNumber = default,
            global::Apify.WritableVersionSourceType? sourceType = default,
            global::System.Collections.Generic.IList<global::Apify.EnvVarRequest>? envVars = default,
            bool? applyEnvVarsToBuild = default,
            string? buildTag = default,
            global::System.Collections.Generic.IList<global::Apify.AnyOf<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>>? sourceFiles = default,
            string? gitRepoUrl = default,
            string? tarballUrl = default,
            string? gitHubGistUrl = default,
            string? actorPath = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}