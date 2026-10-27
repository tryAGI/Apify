
#nullable enable

namespace Apify
{
    /// <summary>
    /// Response of the Slack `chat.postMessage` call. Present only for successful calls of `SLACK_MESSAGE` webhooks.
    /// </summary>
    public sealed partial class WebhookDispatchCallDebugPostMessage
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}