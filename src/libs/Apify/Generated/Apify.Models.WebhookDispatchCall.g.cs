
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDispatchCall
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finishedAt")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseStatus")]
        public int? ResponseStatus { get; set; }

        /// <summary>
        /// Example: {"foo": "bar"}
        /// </summary>
        /// <example>{"foo": "bar"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseBody")]
        public string? ResponseBody { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDispatchCall" /> class.
        /// </summary>
        /// <param name="startedAt"></param>
        /// <param name="finishedAt"></param>
        /// <param name="errorMessage"></param>
        /// <param name="responseStatus"></param>
        /// <param name="responseBody">
        /// Example: {"foo": "bar"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookDispatchCall(
            global::System.DateTime? startedAt,
            global::System.DateTime? finishedAt,
            string? errorMessage,
            int? responseStatus,
            string? responseBody)
        {
            this.StartedAt = startedAt;
            this.FinishedAt = finishedAt;
            this.ErrorMessage = errorMessage;
            this.ResponseStatus = responseStatus;
            this.ResponseBody = responseBody;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDispatchCall" /> class.
        /// </summary>
        public WebhookDispatchCall()
        {
        }
    }
}