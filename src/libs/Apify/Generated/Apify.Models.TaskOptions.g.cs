
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskOptions(
            string? build,
            int? timeoutSecs,
            long? memoryMbytes,
            int? maxItems,
            double? maxTotalChargeUsd,
            bool? restartOnError)
        {
            this.Build = build;
            this.TimeoutSecs = timeoutSecs;
            this.MemoryMbytes = memoryMbytes;
            this.MaxItems = maxItems;
            this.MaxTotalChargeUsd = maxTotalChargeUsd;
            this.RestartOnError = restartOnError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskOptions" /> class.
        /// </summary>
        public TaskOptions()
        {
        }
    }
}