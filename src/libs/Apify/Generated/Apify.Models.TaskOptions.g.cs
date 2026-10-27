
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TaskOptions
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("build")]
        public string? Build { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeoutSecs")]
        public int? TimeoutSecs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoryMbytes")]
        public long? MemoryMbytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxItems")]
        public int? MaxItems { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxTotalChargeUsd")]
        public double? MaxTotalChargeUsd { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restartOnError")]
        public bool? RestartOnError { get; set; }

        /// <summary>
        /// Whether the user explicitly set `maxTotalChargeUsd`. Returned only in schedule action `runOptions`, and only if it was provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isMaxTotalChargeUsdSetByUser")]
        public bool? IsMaxTotalChargeUsdSetByUser { get; set; }

        /// <summary>
        /// Permission level to run the Actor with, overriding the Actor's own setting. Returned only in schedule action `runOptions`, and only if it was provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forcePermissionLevel")]
        public global::Apify.ActorPermissionLevel? ForcePermissionLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskOptions" /> class.
        /// </summary>
        /// <param name="build"></param>
        /// <param name="timeoutSecs"></param>
        /// <param name="memoryMbytes"></param>
        /// <param name="maxItems"></param>
        /// <param name="maxTotalChargeUsd"></param>
        /// <param name="restartOnError"></param>
        /// <param name="isMaxTotalChargeUsdSetByUser">
        /// Whether the user explicitly set `maxTotalChargeUsd`. Returned only in schedule action `runOptions`, and only if it was provided.
        /// </param>
        /// <param name="forcePermissionLevel">
        /// Permission level to run the Actor with, overriding the Actor's own setting. Returned only in schedule action `runOptions`, and only if it was provided.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskOptions(
            string? build,
            int? timeoutSecs,
            long? memoryMbytes,
            int? maxItems,
            double? maxTotalChargeUsd,
            bool? restartOnError,
            bool? isMaxTotalChargeUsdSetByUser,
            global::Apify.ActorPermissionLevel? forcePermissionLevel)
        {
            this.Build = build;
            this.TimeoutSecs = timeoutSecs;
            this.MemoryMbytes = memoryMbytes;
            this.MaxItems = maxItems;
            this.MaxTotalChargeUsd = maxTotalChargeUsd;
            this.RestartOnError = restartOnError;
            this.IsMaxTotalChargeUsdSetByUser = isMaxTotalChargeUsdSetByUser;
            this.ForcePermissionLevel = forcePermissionLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskOptions" /> class.
        /// </summary>
        public TaskOptions()
        {
        }

    }
}