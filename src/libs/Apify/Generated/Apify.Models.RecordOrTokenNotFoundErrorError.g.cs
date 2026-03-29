
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecordOrTokenNotFoundErrorError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.RecordOrTokenNotFoundErrorErrorTypeJsonConverter))]
        public global::Apify.RecordOrTokenNotFoundErrorErrorType? Type { get; set; }

        /// <summary>
        /// Example: Actor was not found or access denied
        /// </summary>
        /// <example>Actor was not found or access denied</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordOrTokenNotFoundErrorError" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message">
        /// Example: Actor was not found or access denied
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecordOrTokenNotFoundErrorError(
            global::Apify.RecordOrTokenNotFoundErrorErrorType? type,
            string? message)
        {
            this.Type = type;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordOrTokenNotFoundErrorError" /> class.
        /// </summary>
        public RecordOrTokenNotFoundErrorError()
        {
        }
    }
}