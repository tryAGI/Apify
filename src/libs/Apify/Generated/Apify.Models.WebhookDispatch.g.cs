
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDispatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebhookId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Status of the webhook dispatch indicating whether the HTTP request was successful.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.WebhookDispatchStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.WebhookDispatchStatus Status { get; set; }

        /// <summary>
        /// Type of event that triggers the webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.WebhookEventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.WebhookEventType EventType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventData")]
        public global::Apify.WebhookDispatchEventData? EventData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public global::Apify.WebhookDispatchWebhookSummary? Webhook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calls")]
        public global::System.Collections.Generic.IList<global::Apify.WebhookDispatchCall>? Calls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDispatch" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="webhookId"></param>
        /// <param name="createdAt"></param>
        /// <param name="status">
        /// Status of the webhook dispatch indicating whether the HTTP request was successful.
        /// </param>
        /// <param name="eventType">
        /// Type of event that triggers the webhook.
        /// </param>
        /// <param name="eventData"></param>
        /// <param name="webhook"></param>
        /// <param name="calls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookDispatch(
            string id,
            string userId,
            string webhookId,
            global::System.DateTime createdAt,
            global::Apify.WebhookDispatchStatus status,
            global::Apify.WebhookEventType eventType,
            global::Apify.WebhookDispatchEventData? eventData,
            global::Apify.WebhookDispatchWebhookSummary? webhook,
            global::System.Collections.Generic.IList<global::Apify.WebhookDispatchCall>? calls)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.WebhookId = webhookId ?? throw new global::System.ArgumentNullException(nameof(webhookId));
            this.CreatedAt = createdAt;
            this.Status = status;
            this.EventType = eventType;
            this.EventData = eventData;
            this.Webhook = webhook;
            this.Calls = calls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDispatch" /> class.
        /// </summary>
        public WebhookDispatch()
        {
        }

    }
}