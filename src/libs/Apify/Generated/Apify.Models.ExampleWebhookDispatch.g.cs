
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExampleWebhookDispatch
    {
        /// <summary>
        /// Status of the webhook dispatch indicating whether the HTTP request was successful.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.WebhookDispatchStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.WebhookDispatchStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finishedAt")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedAt")]
        public global::System.DateTime? RemovedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleWebhookDispatch" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of the webhook dispatch indicating whether the HTTP request was successful.
        /// </param>
        /// <param name="finishedAt"></param>
        /// <param name="removedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExampleWebhookDispatch(
            global::Apify.WebhookDispatchStatus status,
            global::System.DateTime? finishedAt,
            global::System.DateTime? removedAt)
        {
            this.Status = status;
            this.FinishedAt = finishedAt;
            this.RemovedAt = removedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExampleWebhookDispatch" /> class.
        /// </summary>
        public ExampleWebhookDispatch()
        {
        }

    }
}