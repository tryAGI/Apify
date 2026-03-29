
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isAdHoc")]
        public bool? IsAdHoc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventTypes")]
        public global::System.Collections.Generic.IList<global::Apify.WebhookEventType>? EventTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        public global::Apify.WebhookCondition? Condition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignoreSslErrors")]
        public bool? IgnoreSslErrors { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("shouldInterpolateStrings")]
        public bool? ShouldInterpolateStrings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookUpdate" /> class.
        /// </summary>
        /// <param name="isAdHoc"></param>
        /// <param name="eventTypes"></param>
        /// <param name="condition"></param>
        /// <param name="ignoreSslErrors"></param>
        /// <param name="doNotRetry"></param>
        /// <param name="requestUrl"></param>
        /// <param name="payloadTemplate"></param>
        /// <param name="headersTemplate"></param>
        /// <param name="description"></param>
        /// <param name="shouldInterpolateStrings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookUpdate(
            bool? isAdHoc,
            global::System.Collections.Generic.IList<global::Apify.WebhookEventType>? eventTypes,
            global::Apify.WebhookCondition? condition,
            bool? ignoreSslErrors,
            bool? doNotRetry,
            string? requestUrl,
            string? payloadTemplate,
            string? headersTemplate,
            string? description,
            bool? shouldInterpolateStrings)
        {
            this.IsAdHoc = isAdHoc;
            this.EventTypes = eventTypes;
            this.Condition = condition;
            this.IgnoreSslErrors = ignoreSslErrors;
            this.DoNotRetry = doNotRetry;
            this.RequestUrl = requestUrl;
            this.PayloadTemplate = payloadTemplate;
            this.HeadersTemplate = headersTemplate;
            this.Description = description;
            this.ShouldInterpolateStrings = shouldInterpolateStrings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookUpdate" /> class.
        /// </summary>
        public WebhookUpdate()
        {
        }
    }
}