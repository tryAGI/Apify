
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActorRunNotFoundErrorError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.ActorRunNotFoundErrorErrorTypeJsonConverter))]
        public global::Apify.ActorRunNotFoundErrorErrorType? Type { get; set; }

        /// <summary>
        /// Example: Actor run was not found
        /// </summary>
        /// <example>Actor run was not found</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorRunNotFoundErrorError" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message">
        /// Example: Actor run was not found
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActorRunNotFoundErrorError(
            global::Apify.ActorRunNotFoundErrorErrorType? type,
            string? message)
        {
            this.Type = type;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorRunNotFoundErrorError" /> class.
        /// </summary>
        public ActorRunNotFoundErrorError()
        {
        }
    }
}