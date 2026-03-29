
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDispatchEventData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorRunId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActorRunId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDispatchEventData" /> class.
        /// </summary>
        /// <param name="actorId"></param>
        /// <param name="actorRunId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookDispatchEventData(
            string actorId,
            string actorRunId)
        {
            this.ActorId = actorId ?? throw new global::System.ArgumentNullException(nameof(actorId));
            this.ActorRunId = actorRunId ?? throw new global::System.ArgumentNullException(nameof(actorRunId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDispatchEventData" /> class.
        /// </summary>
        public WebhookDispatchEventData()
        {
        }
    }
}