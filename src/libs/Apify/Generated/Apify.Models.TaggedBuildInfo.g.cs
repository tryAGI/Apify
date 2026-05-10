
#nullable enable

namespace Apify
{
    /// <summary>
    /// Information about a tagged build.
    /// </summary>
    public sealed partial class TaggedBuildInfo
    {
        /// <summary>
        /// The ID of the build associated with this tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildId")]
        public string? BuildId { get; set; }

        /// <summary>
        /// The build number/version string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildNumber")]
        public string? BuildNumber { get; set; }

        /// <summary>
        /// The timestamp when the build finished.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finishedAt")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaggedBuildInfo" /> class.
        /// </summary>
        /// <param name="buildId">
        /// The ID of the build associated with this tag.
        /// </param>
        /// <param name="buildNumber">
        /// The build number/version string.
        /// </param>
        /// <param name="finishedAt">
        /// The timestamp when the build finished.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaggedBuildInfo(
            string? buildId,
            string? buildNumber,
            global::System.DateTime? finishedAt)
        {
            this.BuildId = buildId;
            this.BuildNumber = buildNumber;
            this.FinishedAt = finishedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaggedBuildInfo" /> class.
        /// </summary>
        public TaggedBuildInfo()
        {
        }

    }
}