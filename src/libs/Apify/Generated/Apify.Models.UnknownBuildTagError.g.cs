
#nullable enable

namespace Apify
{
    /// <summary>
    /// Example: {"error":{"type":"unknown-build-tag","message":"Build with tag \u0022latest\u0022 was not found. Has the Actor been built already?"}}
    /// </summary>
    public sealed partial class UnknownBuildTagError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.UnknownBuildTagErrorDetailJsonConverter))]
        public global::Apify.UnknownBuildTagErrorDetail? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnknownBuildTagError" /> class.
        /// </summary>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnknownBuildTagError(
            global::Apify.UnknownBuildTagErrorDetail? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnknownBuildTagError" /> class.
        /// </summary>
        public UnknownBuildTagError()
        {
        }
    }
}