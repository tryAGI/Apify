
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RunShort
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorTaskId")]
        public string? ActorTaskId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("buildId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BuildId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildNumber")]
        public string? BuildNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildNumberInt")]
        public int? BuildNumberInt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.RunMeta Meta { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageTotalUsd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UsageTotalUsd { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultKeyValueStoreId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultKeyValueStoreId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultDatasetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultDatasetId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultRequestQueueId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultRequestQueueId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunShort" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="actId"></param>
        /// <param name="status">
        /// Status of an Actor job (run or build).
        /// </param>
        /// <param name="startedAt"></param>
        /// <param name="buildId"></param>
        /// <param name="meta"></param>
        /// <param name="usageTotalUsd"></param>
        /// <param name="defaultKeyValueStoreId"></param>
        /// <param name="defaultDatasetId"></param>
        /// <param name="defaultRequestQueueId"></param>
        /// <param name="userId"></param>
        /// <param name="actorTaskId"></param>
        /// <param name="finishedAt"></param>
        /// <param name="buildNumber"></param>
        /// <param name="buildNumberInt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunShort(
            string id,
            string actId,
            global::Apify.ActorJobStatus status,
            global::System.DateTime startedAt,
            string buildId,
            global::Apify.RunMeta meta,
            double usageTotalUsd,
            string defaultKeyValueStoreId,
            string defaultDatasetId,
            string defaultRequestQueueId,
            string? userId,
            string? actorTaskId,
            global::System.DateTime? finishedAt,
            string? buildNumber,
            int? buildNumberInt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ActId = actId ?? throw new global::System.ArgumentNullException(nameof(actId));
            this.UserId = userId;
            this.ActorTaskId = actorTaskId;
            this.Status = status;
            this.StartedAt = startedAt;
            this.FinishedAt = finishedAt;
            this.BuildId = buildId ?? throw new global::System.ArgumentNullException(nameof(buildId));
            this.BuildNumber = buildNumber;
            this.BuildNumberInt = buildNumberInt;
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
            this.UsageTotalUsd = usageTotalUsd;
            this.DefaultKeyValueStoreId = defaultKeyValueStoreId ?? throw new global::System.ArgumentNullException(nameof(defaultKeyValueStoreId));
            this.DefaultDatasetId = defaultDatasetId ?? throw new global::System.ArgumentNullException(nameof(defaultDatasetId));
            this.DefaultRequestQueueId = defaultRequestQueueId ?? throw new global::System.ArgumentNullException(nameof(defaultRequestQueueId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunShort" /> class.
        /// </summary>
        public RunShort()
        {
        }

    }
}