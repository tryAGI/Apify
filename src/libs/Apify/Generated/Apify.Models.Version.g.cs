
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Version
    {
        /// <summary>
        /// The version number of the Actor. Two numbers separated by a dot, that represent the `MAJOR.MINOR` part of the semantic versioning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionNumber")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionNumber { get; set; }

        /// <summary>
        /// Where the source code of the version lives.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceType")]
        public global::Apify.VersionSourceType? SourceType { get; set; }

        /// <summary>
        /// Environment variables for the version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("envVars")]
        public global::System.Collections.Generic.IList<global::Apify.EnvVar>? EnvVars { get; set; }

        /// <summary>
        /// Whether to inject the environment variables at build time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applyEnvVarsToBuild")]
        public bool? ApplyEnvVarsToBuild { get; set; }

        /// <summary>
        /// The tag name to apply to a successful build of this version. Can be `null` when the version has no build tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildTag")]
        public string? BuildTag { get; set; }

        /// <summary>
        /// Applies when the `sourceType` is `SOURCE_FILES`. Represents the Actor's file structure as an array of files and folders.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceFiles")]
        public global::System.Collections.Generic.IList<global::Apify.AnyOf<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>>? SourceFiles { get; set; }

        /// <summary>
        /// URL of the Git repository to clone the source code from. Applies when the `sourceType` is `GIT_REPO`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitRepoUrl")]
        public string? GitRepoUrl { get; set; }

        /// <summary>
        /// URL to download the source code from as a tarball or ZIP file. Applies when the `sourceType` is `TARBALL`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tarballUrl")]
        public string? TarballUrl { get; set; }

        /// <summary>
        /// URL of the GitHub Gist to clone the source code from. Applies when the `sourceType` is `GITHUB_GIST`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitHubGistUrl")]
        public string? GitHubGistUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Version" /> class.
        /// </summary>
        /// <param name="versionNumber">
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
        /// URL to download the source code from as a tarball or ZIP file. Applies when the `sourceType` is `TARBALL`.
        /// </param>
        /// <param name="gitHubGistUrl">
        /// URL of the GitHub Gist to clone the source code from. Applies when the `sourceType` is `GITHUB_GIST`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Version(
            string versionNumber,
            global::Apify.VersionSourceType? sourceType,
            global::System.Collections.Generic.IList<global::Apify.EnvVar>? envVars,
            bool? applyEnvVarsToBuild,
            string? buildTag,
            global::System.Collections.Generic.IList<global::Apify.AnyOf<global::Apify.SourceCodeFile, global::Apify.SourceCodeFolder>>? sourceFiles,
            string? gitRepoUrl,
            string? tarballUrl,
            string? gitHubGistUrl)
        {
            this.VersionNumber = versionNumber ?? throw new global::System.ArgumentNullException(nameof(versionNumber));
            this.SourceType = sourceType;
            this.EnvVars = envVars;
            this.ApplyEnvVarsToBuild = applyEnvVarsToBuild;
            this.BuildTag = buildTag;
            this.SourceFiles = sourceFiles;
            this.GitRepoUrl = gitRepoUrl;
            this.TarballUrl = tarballUrl;
            this.GitHubGistUrl = gitHubGistUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Version" /> class.
        /// </summary>
        public Version()
        {
        }

    }
}