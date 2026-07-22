
#nullable enable

namespace Apify
{
    /// <summary>
    /// A summary of the webhook that triggered this dispatch.
    /// </summary>
    public sealed partial class WebhookDispatchWebhookSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionType")]
        public string? ActionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        public global::Apify.WebhookCondition? Condition { get; set; }

        /// <summary>
        /// URL of the HTTP request sent by the webhook. It is `null` for hook actions other than the conventional HTTP case (e.g. Slack or email notifications).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestUrl")]
        public string? RequestUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isAdHoc")]
        public bool? IsAdHoc { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDispatchWebhookSummary" /> class.
        /// </summary>
        /// <param name="actionType"></param>
        /// <param name="condition"></param>
        /// <param name="requestUrl">
        /// URL of the HTTP request sent by the webhook. It is `null` for hook actions other than the conventional HTTP case (e.g. Slack or email notifications).
        /// </param>
        /// <param name="isAdHoc"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookDispatchWebhookSummary(
            string? actionType,
            global::Apify.WebhookCondition? condition,
            string? requestUrl,
            bool? isAdHoc)
        {
            this.ActionType = actionType;
            this.Condition = condition;
            this.RequestUrl = requestUrl;
            this.IsAdHoc = isAdHoc;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDispatchWebhookSummary" /> class.
        /// </summary>
        public WebhookDispatchWebhookSummary()
        {
        }

    }
}