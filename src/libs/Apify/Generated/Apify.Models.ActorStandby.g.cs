
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActorStandby
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isEnabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("desiredRequestsPerActorRun")]
        public int? DesiredRequestsPerActorRun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxRequestsPerActorRun")]
        public int? MaxRequestsPerActorRun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idleTimeoutSecs")]
        public int? IdleTimeoutSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("build")]
        public string? Build { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoryMbytes")]
        public long? MemoryMbytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disableStandbyFieldsOverride")]
        public bool? DisableStandbyFieldsOverride { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shouldPassActorInput")]
        public bool? ShouldPassActorInput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorStandby" /> class.
        /// </summary>
        /// <param name="isEnabled"></param>
        /// <param name="desiredRequestsPerActorRun"></param>
        /// <param name="maxRequestsPerActorRun"></param>
        /// <param name="idleTimeoutSecs"></param>
        /// <param name="build"></param>
        /// <param name="memoryMbytes"></param>
        /// <param name="disableStandbyFieldsOverride"></param>
        /// <param name="shouldPassActorInput"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActorStandby(
            bool? isEnabled,
            int? desiredRequestsPerActorRun,
            int? maxRequestsPerActorRun,
            int? idleTimeoutSecs,
            string? build,
            long? memoryMbytes,
            bool? disableStandbyFieldsOverride,
            bool? shouldPassActorInput)
        {
            this.IsEnabled = isEnabled;
            this.DesiredRequestsPerActorRun = desiredRequestsPerActorRun;
            this.MaxRequestsPerActorRun = maxRequestsPerActorRun;
            this.IdleTimeoutSecs = idleTimeoutSecs;
            this.Build = build;
            this.MemoryMbytes = memoryMbytes;
            this.DisableStandbyFieldsOverride = disableStandbyFieldsOverride;
            this.ShouldPassActorInput = shouldPassActorInput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorStandby" /> class.
        /// </summary>
        public ActorStandby()
        {
        }

    }
}