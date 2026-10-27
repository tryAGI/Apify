
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
        /// ID of the Actor run that started this run. Present only when the run was started from another run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorRunId")]
        public string? ActorRunId { get; set; }

        /// <summary>
        /// ID of the webhook dispatch that started the run. Present only when the run was started by a webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookDispatchId")]
        public string? WebhookDispatchId { get; set; }

        /// <summary>
        /// ID of the schedule action that started the Actor. Present only on runs of Actors started by a schedule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduledAct2Id")]
        public string? ScheduledAct2Id { get; set; }

        /// <summary>
        /// ID of the schedule action that started the Actor task. Present only on runs of tasks started by a schedule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduledActorTaskId")]
        public string? ScheduledActorTaskId { get; set; }

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
        /// <param name="actorRunId">
        /// ID of the Actor run that started this run. Present only when the run was started from another run.
        /// </param>
        /// <param name="webhookDispatchId">
        /// ID of the webhook dispatch that started the run. Present only when the run was started by a webhook.
        /// </param>
        /// <param name="scheduledAct2Id">
        /// ID of the schedule action that started the Actor. Present only on runs of Actors started by a schedule.
        /// </param>
        /// <param name="scheduledActorTaskId">
        /// ID of the schedule action that started the Actor task. Present only on runs of tasks started by a schedule.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunMeta(
            global::Apify.RunOrigin origin,
            string? clientIp,
            string? userAgent,
            string? scheduleId,
            global::System.DateTime? scheduledAt,
            string? actorRunId,
            string? webhookDispatchId,
            string? scheduledAct2Id,
            string? scheduledActorTaskId)
        {
            this.Origin = origin;
            this.ClientIp = clientIp;
            this.UserAgent = userAgent;
            this.ScheduleId = scheduleId;
            this.ScheduledAt = scheduledAt;
            this.ActorRunId = actorRunId;
            this.WebhookDispatchId = webhookDispatchId;
            this.ScheduledAct2Id = scheduledAct2Id;
            this.ScheduledActorTaskId = scheduledActorTaskId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunMeta" /> class.
        /// </summary>
        public RunMeta()
        {
        }

    }
}