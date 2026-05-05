#nullable enable

namespace Apify
{
    public partial interface IActorsActorVersionsClient
    {
        /// <summary>
        /// Update version<br/>
        /// Updates Actor version using values specified by a [Version object](#/reference/actors/version-object) passed as JSON in the POST payload.<br/>
        /// If the object does not define a specific property, its value will not be<br/>
        /// updated.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP<br/>
        /// header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL. ([More<br/>
        /// info](#/introduction/authentication)).<br/>
        /// The response is the [Version object](#/reference/actors/version-object) as<br/>
        /// returned by the [Get version](#/reference/actors/version-object/get-version) endpoint.
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
        global::System.Threading.Tasks.Task<global::Apify.VersionResponse> ActVersionPutAsync(
            string actorId,
            string versionNumber,

            global::Apify.CreateOrUpdateVersionRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update version<br/>
        /// Updates Actor version using values specified by a [Version object](#/reference/actors/version-object) passed as JSON in the POST payload.<br/>
        /// If the object does not define a specific property, its value will not be<br/>
        /// updated.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP<br/>
        /// header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL. ([More<br/>
        /// info](#/introduction/authentication)).<br/>
        /// The response is the [Version object](#/reference/actors/version-object) as<br/>
        /// returned by the [Get version](#/reference/actors/version-object/get-version) endpoint.
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
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.VersionResponse>> ActVersionPutAsResponseAsync(
            string actorId,
            string versionNumber,

            global::Apify.CreateOrUpdateVersionRequest request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update version<br/>
        /// Updates Actor version using values specified by a [Version object](#/reference/actors/version-object) passed as JSON in the POST payload.<br/>
        /// If the object does not define a specific property, its value will not be<br/>
        /// updated.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP<br/>
        /// header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL. ([More<br/>
        /// info](#/introduction/authentication)).<br/>
        /// The response is the [Version object](#/reference/actors/version-object) as<br/>
        /// returned by the [Get version](#/reference/actors/version-object/get-version) endpoint.
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
        global::System.Threading.Tasks.Task<global::Apify.VersionResponse> ActVersionPutAsync(
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