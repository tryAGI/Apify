
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuildShort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actId")]
        public string? ActId { get; set; }

        /// <summary>
        /// Status of an Actor job (run or build).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.ActorJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.ActorJobStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finishedAt")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageTotalUsd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UsageTotalUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::Apify.BuildsMeta? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildShort" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status">
        /// Status of an Actor job (run or build).
        /// </param>
        /// <param name="startedAt"></param>
        /// <param name="usageTotalUsd"></param>
        /// <param name="actId"></param>
        /// <param name="finishedAt"></param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildShort(
            string id,
            global::Apify.ActorJobStatus status,
            global::System.DateTime startedAt,
            double usageTotalUsd,
            string? actId,
            global::System.DateTime? finishedAt,
            global::Apify.BuildsMeta? meta)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ActId = actId;
            this.Status = status;
            this.StartedAt = startedAt;
            this.FinishedAt = finishedAt;
            this.UsageTotalUsd = usageTotalUsd;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildShort" /> class.
        /// </summary>
        public BuildShort()
        {
        }

    }
}