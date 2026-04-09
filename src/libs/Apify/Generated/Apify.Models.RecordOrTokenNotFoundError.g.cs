
#nullable enable

namespace Apify
{
    /// <summary>
    /// Example: {"error":{"type":"record-or-token-not-found","message":"Actor was not found or access denied"}}
    /// </summary>
    public sealed partial class RecordOrTokenNotFoundError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.RecordOrTokenNotFoundErrorDetailJsonConverter))]
        public global::Apify.RecordOrTokenNotFoundErrorDetail? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordOrTokenNotFoundError" /> class.
        /// </summary>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecordOrTokenNotFoundError(
            global::Apify.RecordOrTokenNotFoundErrorDetail? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordOrTokenNotFoundError" /> class.
        /// </summary>
        public RecordOrTokenNotFoundError()
        {
        }
    }
}