
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActValidateInputPostResponse
    {
        /// <summary>
        /// Whether the input is valid according to the Actor's input schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Valid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActValidateInputPostResponse" /> class.
        /// </summary>
        /// <param name="valid">
        /// Whether the input is valid according to the Actor's input schema.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActValidateInputPostResponse(
            bool valid)
        {
            this.Valid = valid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActValidateInputPostResponse" /> class.
        /// </summary>
        public ActValidateInputPostResponse()
        {
        }
    }
}