
#nullable enable

namespace Apify
{
    /// <summary>
    /// Represents an Actor run and its associated data.
    /// </summary>
    public sealed partial class Run
    {
        /// <summary>
        /// Unique identifier of the Actor run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// ID of the Actor that was run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActId { get; set; }

        /// <summary>
        /// ID of the user who started the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// ID of the Actor task, if the run was started from a task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorTaskId")]
        public string? ActorTaskId { get; set; }

        /// <summary>
        /// Time when the Actor run started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// Time when the Actor run finished.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finishedAt")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Current status of the Actor run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.ActorJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.ActorJobStatus Status { get; set; }

        /// <summary>
        /// Detailed message about the run status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusMessage")]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// Whether the status message is terminal (final).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isStatusMessageTerminal")]
        public bool? IsStatusMessageTerminal { get; set; }

        /// <summary>
        /// Metadata about the Actor run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.RunMeta Meta { get; set; }

        /// <summary>
        /// Pricing information for the Actor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricingInfo")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.ActorRunPricingInfoJsonConverter))]
        public global::Apify.ActorRunPricingInfo? PricingInfo { get; set; }

        /// <summary>
        /// Statistics of the Actor run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.RunStats Stats { get; set; }

        /// <summary>
        /// A map of charged event types to their counts. The keys are event type identifiers defined by the Actor's pricing model (pay-per-event), and the values are the number of times each event was charged during this run.<br/>
        /// Example: {"actor-start":1,"page-crawled":150,"data-extracted":75}
        /// </summary>
        /// <example>{"actor-start":1,"page-crawled":150,"data-extracted":75}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chargedEventCounts")]
        public global::System.Collections.Generic.Dictionary<string, int>? ChargedEventCounts { get; set; }

        /// <summary>
        /// Configuration options for the Actor run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.RunOptions Options { get; set; }

        /// <summary>
        /// ID of the Actor build used for this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BuildId { get; set; }

        /// <summary>
        /// Exit code of the Actor run process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exitCode")]
        public int? ExitCode { get; set; }

        /// <summary>
        /// General access level for the Actor run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generalAccess")]
        public global::Apify.GeneralAccess? GeneralAccess { get; set; }

        /// <summary>
        /// ID of the default key-value store for this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultKeyValueStoreId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultKeyValueStoreId { get; set; }

        /// <summary>
        /// ID of the default dataset for this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultDatasetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultDatasetId { get; set; }

        /// <summary>
        /// ID of the default request queue for this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultRequestQueueId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DefaultRequestQueueId { get; set; }

        /// <summary>
        /// A map of aliased storage IDs associated with this run, grouped by storage type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storageIds")]
        public global::Apify.RunStorageIds? StorageIds { get; set; }

        /// <summary>
        /// Build number of the Actor build used for this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildNumber")]
        public string? BuildNumber { get; set; }

        /// <summary>
        /// URL of the container running the Actor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("containerUrl")]
        public string? ContainerUrl { get; set; }

        /// <summary>
        /// Whether the container's HTTP server is ready to accept requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isContainerServerReady")]
        public bool? IsContainerServerReady { get; set; }

        /// <summary>
        /// Name of the git branch used for the Actor build.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitBranchName")]
        public string? GitBranchName { get; set; }

        /// <summary>
        /// Resource usage statistics for the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Apify.RunUsage? Usage { get; set; }

        /// <summary>
        /// Total cost in USD for this run. Represents what you actually pay. For run owners: includes platform usage (compute units) and/or event costs depending on the Actor's pricing model. For run non-owners: only available for Pay-Per-Event Actors (event costs only). Requires authentication token to access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageTotalUsd")]
        public double? UsageTotalUsd { get; set; }

        /// <summary>
        /// Platform usage costs breakdown in USD. Only present if you own the run AND are paying for platform usage (Pay-Per-Usage, Rental, or Pay-Per-Event with usage costs like standby Actors). Not available for standard Pay-Per-Event Actors. Requires authentication token to access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageUsd")]
        public global::Apify.RunUsageUsd? UsageUsd { get; set; }

        /// <summary>
        /// List of metamorph events that occurred during the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metamorphs")]
        public global::System.Collections.Generic.IList<global::Apify.Metamorph>? Metamorphs { get; set; }

        /// <summary>
        /// Indicates which party covers platform usage costs for this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platformUsageBillingModel")]
        public string? PlatformUsageBillingModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Run" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the Actor run.
        /// </param>
        /// <param name="actId">
        /// ID of the Actor that was run.
        /// </param>
        /// <param name="userId">
        /// ID of the user who started the run.
        /// </param>
        /// <param name="startedAt">
        /// Time when the Actor run started.
        /// </param>
        /// <param name="status">
        /// Current status of the Actor run.
        /// </param>
        /// <param name="meta">
        /// Metadata about the Actor run.
        /// </param>
        /// <param name="stats">
        /// Statistics of the Actor run.
        /// </param>
        /// <param name="options">
        /// Configuration options for the Actor run.
        /// </param>
        /// <param name="buildId">
        /// ID of the Actor build used for this run.
        /// </param>
        /// <param name="defaultKeyValueStoreId">
        /// ID of the default key-value store for this run.
        /// </param>
        /// <param name="defaultDatasetId">
        /// ID of the default dataset for this run.
        /// </param>
        /// <param name="defaultRequestQueueId">
        /// ID of the default request queue for this run.
        /// </param>
        /// <param name="actorTaskId">
        /// ID of the Actor task, if the run was started from a task.
        /// </param>
        /// <param name="finishedAt">
        /// Time when the Actor run finished.
        /// </param>
        /// <param name="statusMessage">
        /// Detailed message about the run status.
        /// </param>
        /// <param name="isStatusMessageTerminal">
        /// Whether the status message is terminal (final).
        /// </param>
        /// <param name="pricingInfo">
        /// Pricing information for the Actor.
        /// </param>
        /// <param name="chargedEventCounts">
        /// A map of charged event types to their counts. The keys are event type identifiers defined by the Actor's pricing model (pay-per-event), and the values are the number of times each event was charged during this run.<br/>
        /// Example: {"actor-start":1,"page-crawled":150,"data-extracted":75}
        /// </param>
        /// <param name="exitCode">
        /// Exit code of the Actor run process.
        /// </param>
        /// <param name="generalAccess">
        /// General access level for the Actor run.
        /// </param>
        /// <param name="storageIds">
        /// A map of aliased storage IDs associated with this run, grouped by storage type.
        /// </param>
        /// <param name="buildNumber">
        /// Build number of the Actor build used for this run.
        /// </param>
        /// <param name="containerUrl">
        /// URL of the container running the Actor.
        /// </param>
        /// <param name="isContainerServerReady">
        /// Whether the container's HTTP server is ready to accept requests.
        /// </param>
        /// <param name="gitBranchName">
        /// Name of the git branch used for the Actor build.
        /// </param>
        /// <param name="usage">
        /// Resource usage statistics for the run.
        /// </param>
        /// <param name="usageTotalUsd">
        /// Total cost in USD for this run. Represents what you actually pay. For run owners: includes platform usage (compute units) and/or event costs depending on the Actor's pricing model. For run non-owners: only available for Pay-Per-Event Actors (event costs only). Requires authentication token to access.
        /// </param>
        /// <param name="usageUsd">
        /// Platform usage costs breakdown in USD. Only present if you own the run AND are paying for platform usage (Pay-Per-Usage, Rental, or Pay-Per-Event with usage costs like standby Actors). Not available for standard Pay-Per-Event Actors. Requires authentication token to access.
        /// </param>
        /// <param name="metamorphs">
        /// List of metamorph events that occurred during the run.
        /// </param>
        /// <param name="platformUsageBillingModel">
        /// Indicates which party covers platform usage costs for this run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Run(
            string id,
            string actId,
            string userId,
            global::System.DateTime startedAt,
            global::Apify.ActorJobStatus status,
            global::Apify.RunMeta meta,
            global::Apify.RunStats stats,
            global::Apify.RunOptions options,
            string buildId,
            string defaultKeyValueStoreId,
            string defaultDatasetId,
            string defaultRequestQueueId,
            string? actorTaskId,
            global::System.DateTime? finishedAt,
            string? statusMessage,
            bool? isStatusMessageTerminal,
            global::Apify.ActorRunPricingInfo? pricingInfo,
            global::System.Collections.Generic.Dictionary<string, int>? chargedEventCounts,
            int? exitCode,
            global::Apify.GeneralAccess? generalAccess,
            global::Apify.RunStorageIds? storageIds,
            string? buildNumber,
            string? containerUrl,
            bool? isContainerServerReady,
            string? gitBranchName,
            global::Apify.RunUsage? usage,
            double? usageTotalUsd,
            global::Apify.RunUsageUsd? usageUsd,
            global::System.Collections.Generic.IList<global::Apify.Metamorph>? metamorphs,
            string? platformUsageBillingModel)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ActId = actId ?? throw new global::System.ArgumentNullException(nameof(actId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.ActorTaskId = actorTaskId;
            this.StartedAt = startedAt;
            this.FinishedAt = finishedAt;
            this.Status = status;
            this.StatusMessage = statusMessage;
            this.IsStatusMessageTerminal = isStatusMessageTerminal;
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
            this.PricingInfo = pricingInfo;
            this.Stats = stats ?? throw new global::System.ArgumentNullException(nameof(stats));
            this.ChargedEventCounts = chargedEventCounts;
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            this.BuildId = buildId ?? throw new global::System.ArgumentNullException(nameof(buildId));
            this.ExitCode = exitCode;
            this.GeneralAccess = generalAccess;
            this.DefaultKeyValueStoreId = defaultKeyValueStoreId ?? throw new global::System.ArgumentNullException(nameof(defaultKeyValueStoreId));
            this.DefaultDatasetId = defaultDatasetId ?? throw new global::System.ArgumentNullException(nameof(defaultDatasetId));
            this.DefaultRequestQueueId = defaultRequestQueueId ?? throw new global::System.ArgumentNullException(nameof(defaultRequestQueueId));
            this.StorageIds = storageIds;
            this.BuildNumber = buildNumber;
            this.ContainerUrl = containerUrl;
            this.IsContainerServerReady = isContainerServerReady;
            this.GitBranchName = gitBranchName;
            this.Usage = usage;
            this.UsageTotalUsd = usageTotalUsd;
            this.UsageUsd = usageUsd;
            this.Metamorphs = metamorphs;
            this.PlatformUsageBillingModel = platformUsageBillingModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Run" /> class.
        /// </summary>
        public Run()
        {
        }

    }
}