
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorId")]
        public string? ActorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorTaskId")]
        public string? ActorTaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorRunId")]
        public string? ActorRunId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCondition" /> class.
        /// </summary>
        /// <param name="actorId"></param>
        /// <param name="actorTaskId"></param>
        /// <param name="actorRunId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookCondition(
            string? actorId,
            string? actorTaskId,
            string? actorRunId)
        {
            this.ActorId = actorId;
            this.ActorTaskId = actorTaskId;
            this.ActorRunId = actorRunId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCondition" /> class.
        /// </summary>
        public WebhookCondition()
        {
        }

    }
}