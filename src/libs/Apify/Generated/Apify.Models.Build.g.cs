
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// Example: {"id":"HG7ML7M8z78YcAPEB","actId":"janedoe~my-actor","userId":"klmdEpoiojmdEMlk3","startedAt":"2019-11-30T07:34:24.202Z","finishedAt":"2019-12-12T09:30:12.202Z","status":"SUCCEEDED","meta":{"origin":"WEB","clientIp":"172.234.12.34","userAgent":"Mozilla/5.0 (iPad)"},"stats":{"durationMillis":1000,"runTimeSecs":45.718,"computeUnits":0.012699444444444444},"options":{"useCache":false,"betaPackages":false,"memoryMbytes":1024,"diskMbytes":2048},"usage":{"ACTOR_COMPUTE_UNITS":0.08},"usageTotalUsd":0.02,"usageUsd":{"ACTOR_COMPUTE_UNITS":0.02},"inputSchema":"{\\n  \u0022title\u0022: \u0022Schema for ...\u0022}","readme":"# Magic Actor\\nThis Actor is magic.","buildNumber":"0.1.1","actorDefinition":{"actorSpecification":1,"name":"example-actor","version":"1.0","buildTag":"latest","environmentVariables":{"DEBUG_MODE":"false"},"input":{"type":"object","properties":{"prompt":{"type":"string","description":"The text prompt to generate completions for."},"maxTokens":{"type":"integer","description":"The maximum number of tokens to generate."}},"required":["prompt"]},"storages":{"dataset":{"type":"object","$schema":"http://json-schema.org/draft-07/schema#","properties":{"id":{"type":"string","description":"Unique identifier for the generated text."},"text":{"type":"string","description":"The generated text output from the model."}},"required":["id","text"]}},"minMemoryMbytes":512,"maxMemoryMbytes":2048,"usesStandbyMode":false}}
    /// </summary>
    public sealed partial class Build
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

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
        /// Status of an Actor job (run or build).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.ActorJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.ActorJobStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.BuildsMeta Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        public global::Apify.BuildStats? Stats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::Apify.BuildOptions? Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Apify.BuildUsage? Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageTotalUsd")]
        public double? UsageTotalUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageUsd")]
        public global::Apify.BuildUsage? UsageUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputSchema")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? InputSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readme")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Readme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildNumber")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BuildNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorDefinition")]
        public global::Apify.ActorDefinition? ActorDefinition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Build" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="actId"></param>
        /// <param name="userId"></param>
        /// <param name="startedAt"></param>
        /// <param name="status">
        /// Status of an Actor job (run or build).
        /// </param>
        /// <param name="meta"></param>
        /// <param name="buildNumber"></param>
        /// <param name="finishedAt"></param>
        /// <param name="stats"></param>
        /// <param name="options"></param>
        /// <param name="usage"></param>
        /// <param name="usageTotalUsd"></param>
        /// <param name="usageUsd"></param>
        /// <param name="actorDefinition"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Build(
            string id,
            string actId,
            string userId,
            global::System.DateTime startedAt,
            global::Apify.ActorJobStatus status,
            global::Apify.BuildsMeta meta,
            string buildNumber,
            global::System.DateTime? finishedAt,
            global::Apify.BuildStats? stats,
            global::Apify.BuildOptions? options,
            global::Apify.BuildUsage? usage,
            double? usageTotalUsd,
            global::Apify.BuildUsage? usageUsd,
            global::Apify.ActorDefinition? actorDefinition)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ActId = actId ?? throw new global::System.ArgumentNullException(nameof(actId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.StartedAt = startedAt;
            this.FinishedAt = finishedAt;
            this.Status = status;
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
            this.Stats = stats;
            this.Options = options;
            this.Usage = usage;
            this.UsageTotalUsd = usageTotalUsd;
            this.UsageUsd = usageUsd;
            this.BuildNumber = buildNumber ?? throw new global::System.ArgumentNullException(nameof(buildNumber));
            this.ActorDefinition = actorDefinition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Build" /> class.
        /// </summary>
        public Build()
        {
        }
    }
}