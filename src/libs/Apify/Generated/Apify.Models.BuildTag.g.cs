
#nullable enable

namespace Apify
{
    /// <summary>
    /// The name of the build tag.
    /// </summary>
    public sealed partial class BuildTag
    {
        /// <summary>
        /// The ID of the build to assign to the tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BuildId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildTag" /> class.
        /// </summary>
        /// <param name="buildId">
        /// The ID of the build to assign to the tag.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildTag(
            string buildId)
        {
            this.BuildId = buildId ?? throw new global::System.ArgumentNullException(nameof(buildId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildTag" /> class.
        /// </summary>
        public BuildTag()
        {
        }

    }
}