
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnknownBuildTagErrorError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.UnknownBuildTagErrorErrorTypeJsonConverter))]
        public global::Apify.UnknownBuildTagErrorErrorType? Type { get; set; }

        /// <summary>
        /// Example: Build with tag "latest" was not found. Has the Actor been built already?
        /// </summary>
        /// <example>Build with tag "latest" was not found. Has the Actor been built already?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnknownBuildTagErrorError" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message">
        /// Example: Build with tag "latest" was not found. Has the Actor been built already?
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnknownBuildTagErrorError(
            global::Apify.UnknownBuildTagErrorErrorType? type,
            string? message)
        {
            this.Type = type;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnknownBuildTagErrorError" /> class.
        /// </summary>
        public UnknownBuildTagErrorError()
        {
        }
    }
}