
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RunOptions
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("build")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Build { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeoutSecs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TimeoutSecs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoryMbytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long MemoryMbytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diskMbytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long DiskMbytes { get; set; }

        /// <summary>
        /// Whether to automatically restart the run if it fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restartOnError")]
        public bool? RestartOnError { get; set; }

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
        /// Whether the user explicitly set `maxTotalChargeUsd` when starting the run. Not present for pay-per-result Actors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isMaxTotalChargeUsdSetByUser")]
        public bool? IsMaxTotalChargeUsdSetByUser { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunOptions" /> class.
        /// </summary>
        /// <param name="build"></param>
        /// <param name="timeoutSecs"></param>
        /// <param name="memoryMbytes"></param>
        /// <param name="diskMbytes"></param>
        /// <param name="restartOnError">
        /// Whether to automatically restart the run if it fails.
        /// </param>
        /// <param name="maxItems"></param>
        /// <param name="maxTotalChargeUsd"></param>
        /// <param name="isMaxTotalChargeUsdSetByUser">
        /// Whether the user explicitly set `maxTotalChargeUsd` when starting the run. Not present for pay-per-result Actors.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunOptions(
            string build,
            int timeoutSecs,
            long memoryMbytes,
            long diskMbytes,
            bool? restartOnError,
            int? maxItems,
            double? maxTotalChargeUsd,
            bool? isMaxTotalChargeUsdSetByUser)
        {
            this.Build = build ?? throw new global::System.ArgumentNullException(nameof(build));
            this.TimeoutSecs = timeoutSecs;
            this.MemoryMbytes = memoryMbytes;
            this.DiskMbytes = diskMbytes;
            this.RestartOnError = restartOnError;
            this.MaxItems = maxItems;
            this.MaxTotalChargeUsd = maxTotalChargeUsd;
            this.IsMaxTotalChargeUsdSetByUser = isMaxTotalChargeUsdSetByUser;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunOptions" /> class.
        /// </summary>
        public RunOptions()
        {
        }

    }
}