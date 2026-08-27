
#nullable enable

namespace Apify
{
    /// <summary>
    /// Minimal representation of an ad-hoc webhook attached to a single Actor run or build via the<br/>
    /// `webhooks` query parameter. The query parameter value is a Base64-encoded JSON array whose<br/>
    /// items match this schema. Persistent webhook fields (e.g. `condition`) are not used here.
    /// </summary>
    public sealed partial class WebhookRepresentation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventTypes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Apify.WebhookEventType> EventTypes { get; set; }

        /// <summary>
        /// The URL to which the webhook sends its payload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestUrl { get; set; }

        /// <summary>
        /// Optional template for the JSON payload sent by the webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payloadTemplate")]
        public string? PayloadTemplate { get; set; }

        /// <summary>
        /// Optional template for the HTTP headers sent by the webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headersTemplate")]
        public string? HeadersTemplate { get; set; }

        /// <summary>
        /// Flag to also interpolate `{{...}}` variables inside string values of the payload and headers templates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shouldInterpolateStrings")]
        public bool? ShouldInterpolateStrings { get; set; }

        /// <summary>
        /// Key that prevents creating duplicate webhooks, e.g. when the run-starting request is retried.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idempotencyKey")]
        public string? IdempotencyKey { get; set; }

        /// <summary>
        /// Flag to ignore SSL errors when the webhook sends the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignoreSslErrors")]
        public bool? IgnoreSslErrors { get; set; }

        /// <summary>
        /// Flag to skip retrying the webhook request on failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("doNotRetry")]
        public bool? DoNotRetry { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepresentation" /> class.
        /// </summary>
        /// <param name="eventTypes"></param>
        /// <param name="requestUrl">
        /// The URL to which the webhook sends its payload.
        /// </param>
        /// <param name="payloadTemplate">
        /// Optional template for the JSON payload sent by the webhook.
        /// </param>
        /// <param name="headersTemplate">
        /// Optional template for the HTTP headers sent by the webhook.
        /// </param>
        /// <param name="shouldInterpolateStrings">
        /// Flag to also interpolate `{{...}}` variables inside string values of the payload and headers templates.
        /// </param>
        /// <param name="idempotencyKey">
        /// Key that prevents creating duplicate webhooks, e.g. when the run-starting request is retried.
        /// </param>
        /// <param name="ignoreSslErrors">
        /// Flag to ignore SSL errors when the webhook sends the request.
        /// </param>
        /// <param name="doNotRetry">
        /// Flag to skip retrying the webhook request on failure.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookRepresentation(
            global::System.Collections.Generic.IList<global::Apify.WebhookEventType> eventTypes,
            string requestUrl,
            string? payloadTemplate,
            string? headersTemplate,
            bool? shouldInterpolateStrings,
            string? idempotencyKey,
            bool? ignoreSslErrors,
            bool? doNotRetry)
        {
            this.EventTypes = eventTypes ?? throw new global::System.ArgumentNullException(nameof(eventTypes));
            this.RequestUrl = requestUrl ?? throw new global::System.ArgumentNullException(nameof(requestUrl));
            this.PayloadTemplate = payloadTemplate;
            this.HeadersTemplate = headersTemplate;
            this.ShouldInterpolateStrings = shouldInterpolateStrings;
            this.IdempotencyKey = idempotencyKey;
            this.IgnoreSslErrors = ignoreSslErrors;
            this.DoNotRetry = doNotRetry;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepresentation" /> class.
        /// </summary>
        public WebhookRepresentation()
        {
        }

    }
}