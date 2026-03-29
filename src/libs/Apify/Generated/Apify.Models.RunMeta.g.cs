
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.RunOriginJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.RunOrigin Origin { get; set; }

        /// <summary>
        /// IP address of the client that started the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientIp")]
        public string? ClientIp { get; set; }

        /// <summary>
        /// User agent of the client that started the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userAgent")]
        public string? UserAgent { get; set; }

        /// <summary>
        /// ID of the schedule that triggered the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduleId")]
        public string? ScheduleId { get; set; }

        /// <summary>
        /// Time when the run was scheduled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduledAt")]
        public global::System.DateTime? ScheduledAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunMeta" /> class.
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="clientIp">
        /// IP address of the client that started the run.
        /// </param>
        /// <param name="userAgent">
        /// User agent of the client that started the run.
        /// </param>
        /// <param name="scheduleId">
        /// ID of the schedule that triggered the run.
        /// </param>
        /// <param name="scheduledAt">
        /// Time when the run was scheduled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunMeta(
            global::Apify.RunOrigin origin,
            string? clientIp,
            string? userAgent,
            string? scheduleId,
            global::System.DateTime? scheduledAt)
        {
            this.Origin = origin;
            this.ClientIp = clientIp;
            this.UserAgent = userAgent;
            this.ScheduleId = scheduleId;
            this.ScheduledAt = scheduledAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunMeta" /> class.
        /// </summary>
        public RunMeta()
        {
        }
    }
}