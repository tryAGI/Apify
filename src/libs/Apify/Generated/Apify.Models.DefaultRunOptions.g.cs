
#nullable enable

namespace Apify
{
    /// <summary>
    /// The default settings applied to an Actor run. Can be overridden elsewhere.
    /// </summary>
    public sealed partial class DefaultRunOptions
    {
        /// <summary>
        /// Which build to run. Either a build tag or a version number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("build")]
        public string? Build { get; set; }

        /// <summary>
        /// Timeout in seconds. 0 if no timeout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeoutSecs")]
        public int? TimeoutSecs { get; set; }

        /// <summary>
        /// In MB, the amount of memory allocated to the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoryMbytes")]
        public long? MemoryMbytes { get; set; }

        /// <summary>
        /// Whether to automatically restart the run if it fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restartOnError")]
        public bool? RestartOnError { get; set; }

        /// <summary>
        /// Maximum number of items the run might produce.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxItems")]
        public int? MaxItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forcePermissionLevel")]
        public global::Apify.ActorPermissionLevel? ForcePermissionLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultRunOptions" /> class.
        /// </summary>
        /// <param name="build">
        /// Which build to run. Either a build tag or a version number.
        /// </param>
        /// <param name="timeoutSecs">
        /// Timeout in seconds. 0 if no timeout.
        /// </param>
        /// <param name="memoryMbytes">
        /// In MB, the amount of memory allocated to the run.
        /// </param>
        /// <param name="restartOnError">
        /// Whether to automatically restart the run if it fails.
        /// </param>
        /// <param name="maxItems">
        /// Maximum number of items the run might produce.
        /// </param>
        /// <param name="forcePermissionLevel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DefaultRunOptions(
            string? build,
            int? timeoutSecs,
            long? memoryMbytes,
            bool? restartOnError,
            int? maxItems,
            global::Apify.ActorPermissionLevel? forcePermissionLevel)
        {
            this.Build = build;
            this.TimeoutSecs = timeoutSecs;
            this.MemoryMbytes = memoryMbytes;
            this.RestartOnError = restartOnError;
            this.MaxItems = maxItems;
            this.ForcePermissionLevel = forcePermissionLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultRunOptions" /> class.
        /// </summary>
        public DefaultRunOptions()
        {
        }

    }
}