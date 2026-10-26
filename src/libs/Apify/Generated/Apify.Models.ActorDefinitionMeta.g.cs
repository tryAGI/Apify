
#nullable enable

namespace Apify
{
    /// <summary>
    /// Additional information about the Actor.
    /// </summary>
    public sealed partial class ActorDefinitionMeta
    {
        /// <summary>
        /// The ID of the template from which the Actor was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateId")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// The tool or model that generated the Actor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generatedBy")]
        public string? GeneratedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorDefinitionMeta" /> class.
        /// </summary>
        /// <param name="templateId">
        /// The ID of the template from which the Actor was created.
        /// </param>
        /// <param name="generatedBy">
        /// The tool or model that generated the Actor.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActorDefinitionMeta(
            string? templateId,
            string? generatedBy)
        {
            this.TemplateId = templateId;
            this.GeneratedBy = generatedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorDefinitionMeta" /> class.
        /// </summary>
        public ActorDefinitionMeta()
        {
        }

    }
}