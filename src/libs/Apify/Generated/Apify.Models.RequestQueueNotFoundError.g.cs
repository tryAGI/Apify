
#nullable enable

namespace Apify
{
    /// <summary>
    /// Example: {"error":{"type":"record-not-found","message":"Request Queue was not found"}}
    /// </summary>
    public sealed partial class RequestQueueNotFoundError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.RecordNotFoundErrorDetailJsonConverter))]
        public global::Apify.RecordNotFoundErrorDetail? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestQueueNotFoundError" /> class.
        /// </summary>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestQueueNotFoundError(
            global::Apify.RecordNotFoundErrorDetail? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestQueueNotFoundError" /> class.
        /// </summary>
        public RequestQueueNotFoundError()
        {
        }
    }
}