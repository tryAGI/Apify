
#nullable enable

namespace Apify
{
    /// <summary>
    /// Slack message configuration. Present only when `actionType` is `SLACK_MESSAGE`.
    /// </summary>
    public sealed partial class WebhookSlackMessage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userIntegrationId")]
        public string? UserIntegrationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channelId")]
        public string? ChannelId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageTemplate")]
        public string? MessageTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSlackMessage" /> class.
        /// </summary>
        /// <param name="userIntegrationId"></param>
        /// <param name="channelId"></param>
        /// <param name="messageTemplate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookSlackMessage(
            string? userIntegrationId,
            string? channelId,
            string? messageTemplate)
        {
            this.UserIntegrationId = userIntegrationId;
            this.ChannelId = channelId;
            this.MessageTemplate = messageTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSlackMessage" /> class.
        /// </summary>
        public WebhookSlackMessage()
        {
        }

    }
}