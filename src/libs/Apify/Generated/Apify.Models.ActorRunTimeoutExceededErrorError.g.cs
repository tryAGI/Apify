
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActorRunTimeoutExceededErrorError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.ActorRunTimeoutExceededErrorErrorTypeJsonConverter))]
        public global::Apify.ActorRunTimeoutExceededErrorErrorType? Type { get; set; }

        /// <summary>
        /// Example: Actor run exceeded the timeout of 300 seconds for this API endpoint
        /// </summary>
        /// <example>Actor run exceeded the timeout of 300 seconds for this API endpoint</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorRunTimeoutExceededErrorError" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message">
        /// Example: Actor run exceeded the timeout of 300 seconds for this API endpoint
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActorRunTimeoutExceededErrorError(
            global::Apify.ActorRunTimeoutExceededErrorErrorType? type,
            string? message)
        {
            this.Type = type;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorRunTimeoutExceededErrorError" /> class.
        /// </summary>
        public ActorRunTimeoutExceededErrorError()
        {
        }
    }
}