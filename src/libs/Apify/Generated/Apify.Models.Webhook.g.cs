
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Webhook
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
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modifiedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ModifiedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isAdHoc")]
        public bool? IsAdHoc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shouldInterpolateStrings")]
        public bool? ShouldInterpolateStrings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventTypes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Apify.WebhookEventType> EventTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.WebhookCondition Condition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignoreSslErrors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IgnoreSslErrors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("doNotRetry")]
        public bool? DoNotRetry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestUrl")]
        public string? RequestUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payloadTemplate")]
        public string? PayloadTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headersTemplate")]
        public string? HeadersTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastDispatch")]
        public global::Apify.ExampleWebhookDispatch? LastDispatch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        public global::Apify.WebhookStats? Stats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Webhook" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="userId"></param>
        /// <param name="eventTypes"></param>
        /// <param name="condition"></param>
        /// <param name="ignoreSslErrors"></param>
        /// <param name="isAdHoc"></param>
        /// <param name="shouldInterpolateStrings"></param>
        /// <param name="doNotRetry"></param>
        /// <param name="requestUrl"></param>
        /// <param name="payloadTemplate"></param>
        /// <param name="headersTemplate"></param>
        /// <param name="description"></param>
        /// <param name="lastDispatch"></param>
        /// <param name="stats"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Webhook(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime modifiedAt,
            string userId,
            global::System.Collections.Generic.IList<global::Apify.WebhookEventType> eventTypes,
            global::Apify.WebhookCondition condition,
            bool ignoreSslErrors,
            bool? isAdHoc,
            bool? shouldInterpolateStrings,
            bool? doNotRetry,
            string? requestUrl,
            string? payloadTemplate,
            string? headersTemplate,
            string? description,
            global::Apify.ExampleWebhookDispatch? lastDispatch,
            global::Apify.WebhookStats? stats)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.IsAdHoc = isAdHoc;
            this.ShouldInterpolateStrings = shouldInterpolateStrings;
            this.EventTypes = eventTypes ?? throw new global::System.ArgumentNullException(nameof(eventTypes));
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
            this.IgnoreSslErrors = ignoreSslErrors;
            this.DoNotRetry = doNotRetry;
            this.RequestUrl = requestUrl;
            this.PayloadTemplate = payloadTemplate;
            this.HeadersTemplate = headersTemplate;
            this.Description = description;
            this.LastDispatch = lastDispatch;
            this.Stats = stats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Webhook" /> class.
        /// </summary>
        public Webhook()
        {
        }

    }
}