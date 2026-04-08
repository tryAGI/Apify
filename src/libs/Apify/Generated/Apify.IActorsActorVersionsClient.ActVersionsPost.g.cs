#nullable enable

namespace Apify
{
    public partial interface IActorsActorVersionsClient
    {
        /// <summary>
        /// Create version<br/>
        /// Creates a version of an Actor using values specified in a [Version<br/>
        /// object](#/reference/actors/version-object) passed as JSON in the POST<br/>
        /// payload.<br/>
        /// The request must specify `versionNumber` and `sourceType` parameters (as<br/>
        /// strings) in the JSON payload and a `Content-Type: application/json` HTTP<br/>
        /// header.<br/>
        /// Each `sourceType` requires its own additional properties to be passed to the<br/>
        /// JSON payload object. These are outlined in the [Version<br/>
        /// object](#/reference/actors/version-object) table below and in more detail in<br/>
        /// the [Apify<br/>
        /// documentation](https://docs.apify.com/platform/actors/development/deployment/source-types).<br/>
        /// For example, if an Actor's source code is stored in a [GitHub<br/>
        /// repository](https://docs.apify.com/platform/actors/development/deployment/source-types#git-repository),<br/>
        /// you will set the `sourceType` to `GIT_REPO` and pass the repository's URL in<br/>
        /// the `gitRepoUrl` property.<br/>
        /// ```<br/>
        /// {<br/>
        ///     "versionNumber": "0.1",<br/>
        ///     "sourceType": "GIT_REPO",<br/>
        ///     "gitRepoUrl": "https://github.com/my-github-account/actor-repo"<br/>
        /// }<br/>
        /// ```<br/>
        /// The response is the [Version object](#/reference/actors/version-object) as<br/>
        /// returned by the [Get version](#/reference/actors/version-object/get-version) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.VersionResponse> ActVersionsPostAsync(
            string actorId,

            global::Apify.CreateOrUpdateVersionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create version<br/>
        /// Creates a version of an Actor using values specified in a [Version<br/>
        /// object](#/reference/actors/version-object) passed as JSON in the POST<br/>
        /// payload.<br/>
        /// The request must specify `versionNumber` and `sourceType` parameters (as<br/>
        /// strings) in the JSON payload and a `Content-Type: application/json` HTTP<br/>
        /// header.<br/>
        /// Each `sourceType` requires its own additional properties to be passed to the<br/>
        /// JSON payload object. These are outlined in the [Version<br/>
        /// object](#/reference/actors/version-object) table below and in more detail in<br/>
        /// the [Apify<br/>
        /// documentation](https://docs.apify.com/platform/actors/development/deployment/source-types).<br/>
        /// For example, if an Actor's source code is stored in a [GitHub<br/>
        /// repository](https://docs.apify.com/platform/actors/development/deployment/source-types#git-repository),<br/>
        /// you will set the `sourceType` to `GIT_REPO` and pass the repository's URL in<br/>
        /// the `gitRepoUrl` property.<br/>
        /// ```<br/>
        /// {<br/>
        ///     "versionNumber": "0.1",<br/>
        ///     "sourceType": "GIT_REPO",<br/>
        ///     "gitRepoUrl": "https://github.com/my-github-account/actor-repo"<br/>
        /// }<br/>
        /// ```<br/>
        /// The response is the [Version object](#/reference/actors/version-object) as<br/>
        /// returned by the [Get version](#/reference/actors/version-object/get-version) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.VersionResponse>> ActVersionsPostAsResponseAsync(
            string actorId,

            global::Apify.CreateOrUpdateVersionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create version<br/>
        /// Creates a version of an Actor using values specified in a [Version<br/>
        /// object](#/reference/actors/version-object) passed as JSON in the POST<br/>
        /// payload.<br/>
        /// The request must specify `versionNumber` and `sourceType` parameters (as<br/>
        /// strings) in the JSON payload and a `Content-Type: application/json` HTTP<br/>
        /// header.<br/>
        /// Each `sourceType` requires its own additional properties to be passed to the<br/>
        /// JSON payload object. These are outlined in the [Version<br/>
        /// object](#/reference/actors/version-object) table below and in more detail in<br/>
        /// the [Apify<br/>
        /// documentation](https://docs.apify.com/platform/actors/development/deployment/source-types).<br/>
        /// For example, if an Actor's source code is stored in a [GitHub<br/>
        /// repository](https://docs.apify.com/platform/actors/development/deployment/source-types#git-repository),<br/>
        /// you will set the `sourceType` to `GIT_REPO` and pass the repository's URL in<br/>
        /// the `gitRepoUrl` property.<br/>
        /// ```<br/>
        /// {<br/>
        ///     "versionNumber": "0.1",<br/>
        ///     "sourceType": "GIT_REPO",<br/>
        ///     "gitRepoUrl": "https://github.com/my-github-account/actor-repo"<br/>
        /// }<br/>
        /// ```<br/>
        /// The response is the [Version object](#/reference/actors/version-object) as<br/>
        /// returned by the [Get version](#/reference/actors/version-object/get-version) endpoint.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="versionNumber"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.VersionResponse> ActVersionsPostAsync(
            string actorId,
            string? versionNumber = default,
            global::Apify.VersionSourceType? sourceType = default,
            global::System.Collections.Generic.IList<global::Apify.EnvVarRequest>? envVars = default,
            bool? applyEnvVarsToBuild = default,
            string? buildTag = default,
            global::System.Collections.Generic.IList<global::Apify.AnyOf<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>>? sourceFiles = default,
            string? gitRepoUrl = default,
            string? tarballUrl = default,
            string? gitHubGistUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}