
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ActorStandby
    {
        /// <summary>
        /// Whether standby mode is enabled for the Actor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isEnabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Target number of concurrent HTTP requests a single run is configured to handle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("desiredRequestsPerActorRun")]
        public int? DesiredRequestsPerActorRun { get; set; }

        /// <summary>
        /// Maximum number of concurrent HTTP requests that can be routed to a single run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxRequestsPerActorRun")]
        public int? MaxRequestsPerActorRun { get; set; }

        /// <summary>
        /// In seconds, how long a run can stay idle without incoming requests before it's terminated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idleTimeoutSecs")]
        public int? IdleTimeoutSecs { get; set; }

        /// <summary>
        /// Which build to run in standby mode. Either a build tag or a version number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("build")]
        public string? Build { get; set; }

        /// <summary>
        /// In MB, the amount of memory allocated to the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoryMbytes")]
        public long? MemoryMbytes { get; set; }

        /// <summary>
        /// If `true`, prevents the standby mode configuration from being overridden elsewhere.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disableStandbyFieldsOverride")]
        public bool? DisableStandbyFieldsOverride { get; set; }

        /// <summary>
        /// Whether to pass the Actor's input to the standby run. If `false`, the standby runs start with no input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shouldPassActorInput")]
        public bool? ShouldPassActorInput { get; set; }

        /// <summary>
        /// Whether each user gets their own standby runs (`SINGLE_TENANT`) or runs are shared across users (`MULTI_TENANT`). Set by Apify.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenancy")]
        public string? Tenancy { get; set; }

        /// <summary>
        /// Whether standby requests can be authenticated with an Apify Console session. Set by Apify.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isConsoleAuthEnabled")]
        public bool? IsConsoleAuthEnabled { get; set; }

        /// <summary>
        /// Whether standby requests can be made without an API token. Set by Apify.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isTokenlessEnabled")]
        public bool? IsTokenlessEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorStandby" /> class.
        /// </summary>
        /// <param name="isEnabled">
        /// Whether standby mode is enabled for the Actor.
        /// </param>
        /// <param name="desiredRequestsPerActorRun">
        /// Target number of concurrent HTTP requests a single run is configured to handle.
        /// </param>
        /// <param name="maxRequestsPerActorRun">
        /// Maximum number of concurrent HTTP requests that can be routed to a single run.
        /// </param>
        /// <param name="idleTimeoutSecs">
        /// In seconds, how long a run can stay idle without incoming requests before it's terminated.
        /// </param>
        /// <param name="build">
        /// Which build to run in standby mode. Either a build tag or a version number.
        /// </param>
        /// <param name="memoryMbytes">
        /// In MB, the amount of memory allocated to the run.
        /// </param>
        /// <param name="disableStandbyFieldsOverride">
        /// If `true`, prevents the standby mode configuration from being overridden elsewhere.
        /// </param>
        /// <param name="shouldPassActorInput">
        /// Whether to pass the Actor's input to the standby run. If `false`, the standby runs start with no input.
        /// </param>
        /// <param name="tenancy">
        /// Whether each user gets their own standby runs (`SINGLE_TENANT`) or runs are shared across users (`MULTI_TENANT`). Set by Apify.
        /// </param>
        /// <param name="isConsoleAuthEnabled">
        /// Whether standby requests can be authenticated with an Apify Console session. Set by Apify.
        /// </param>
        /// <param name="isTokenlessEnabled">
        /// Whether standby requests can be made without an API token. Set by Apify.
        /// </param>
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
            bool? shouldPassActorInput,
            string? tenancy,
            bool? isConsoleAuthEnabled,
            bool? isTokenlessEnabled)
        {
            this.IsEnabled = isEnabled;
            this.DesiredRequestsPerActorRun = desiredRequestsPerActorRun;
            this.MaxRequestsPerActorRun = maxRequestsPerActorRun;
            this.IdleTimeoutSecs = idleTimeoutSecs;
            this.Build = build;
            this.MemoryMbytes = memoryMbytes;
            this.DisableStandbyFieldsOverride = disableStandbyFieldsOverride;
            this.ShouldPassActorInput = shouldPassActorInput;
            this.Tenancy = tenancy;
            this.IsConsoleAuthEnabled = isConsoleAuthEnabled;
            this.IsTokenlessEnabled = isTokenlessEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorStandby" /> class.
        /// </summary>
        public ActorStandby()
        {
        }

    }
}