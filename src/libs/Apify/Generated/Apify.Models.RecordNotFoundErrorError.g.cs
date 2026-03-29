
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecordNotFoundErrorError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.RecordNotFoundErrorErrorTypeJsonConverter))]
        public global::Apify.RecordNotFoundErrorErrorType? Type { get; set; }

        /// <summary>
        /// Example: Record was not found
        /// </summary>
        /// <example>Record was not found</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordNotFoundErrorError" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message">
        /// Example: Record was not found
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecordNotFoundErrorError(
            global::Apify.RecordNotFoundErrorErrorType? type,
            string? message)
        {
            this.Type = type;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordNotFoundErrorError" /> class.
        /// </summary>
        public RecordNotFoundErrorError()
        {
        }
    }
}