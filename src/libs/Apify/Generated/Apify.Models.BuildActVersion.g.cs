
#nullable enable

namespace Apify
{
    /// <summary>
    /// Snapshot of the Actor version that this build was created from.
    /// </summary>
    public sealed partial class BuildActVersion
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.VersionSourceTypeJsonConverter))]
        public global::Apify.VersionSourceType? SourceType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildTag")]
        public string? BuildTag { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionNumber")]
        public string? VersionNumber { get; set; }

        /// <summary>
        /// URL of the git repository, present when sourceType is GIT_REPO.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitRepoUrl")]
        public string? GitRepoUrl { get; set; }

        /// <summary>
        /// Inline source files, present when sourceType is SOURCE_FILES.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceFiles")]
        public global::System.Collections.Generic.IList<global::Apify.SourceCodeFile>? SourceFiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildActVersion" /> class.
        /// </summary>
        /// <param name="sourceType"></param>
        /// <param name="buildTag"></param>
        /// <param name="versionNumber"></param>
        /// <param name="gitRepoUrl">
        /// URL of the git repository, present when sourceType is GIT_REPO.
        /// </param>
        /// <param name="sourceFiles">
        /// Inline source files, present when sourceType is SOURCE_FILES.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildActVersion(
            global::Apify.VersionSourceType? sourceType,
            string? buildTag,
            string? versionNumber,
            string? gitRepoUrl,
            global::System.Collections.Generic.IList<global::Apify.SourceCodeFile>? sourceFiles)
        {
            this.SourceType = sourceType;
            this.BuildTag = buildTag;
            this.VersionNumber = versionNumber;
            this.GitRepoUrl = gitRepoUrl;
            this.SourceFiles = sourceFiles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildActVersion" /> class.
        /// </summary>
        public BuildActVersion()
        {
        }

    }
}