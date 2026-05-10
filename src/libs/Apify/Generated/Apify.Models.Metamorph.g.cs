
#nullable enable

namespace Apify
{
    /// <summary>
    /// Information about a metamorph event that occurred during the run.
    /// </summary>
    public sealed partial class Metamorph
    {
        /// <summary>
        /// Time when the metamorph occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// ID of the Actor that the run was metamorphed to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActorId { get; set; }

        /// <summary>
        /// ID of the build used for the metamorphed Actor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BuildId { get; set; }

        /// <summary>
        /// Key of the input record in the key-value store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputKey")]
        public string? InputKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Metamorph" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// Time when the metamorph occurred.
        /// </param>
        /// <param name="actorId">
        /// ID of the Actor that the run was metamorphed to.
        /// </param>
        /// <param name="buildId">
        /// ID of the build used for the metamorphed Actor.
        /// </param>
        /// <param name="inputKey">
        /// Key of the input record in the key-value store.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Metamorph(
            global::System.DateTime createdAt,
            string actorId,
            string buildId,
            string? inputKey)
        {
            this.CreatedAt = createdAt;
            this.ActorId = actorId ?? throw new global::System.ArgumentNullException(nameof(actorId));
            this.BuildId = buildId ?? throw new global::System.ArgumentNullException(nameof(buildId));
            this.InputKey = inputKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Metamorph" /> class.
        /// </summary>
        public Metamorph()
        {
        }

    }
}