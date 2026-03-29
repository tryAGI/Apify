
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActorRunFailedErrorError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.ActorRunFailedErrorErrorTypeJsonConverter))]
        public global::Apify.ActorRunFailedErrorErrorType? Type { get; set; }

        /// <summary>
        /// Example: Actor run did not succeed (run ID: 55uatRrZib4xbZs, status: FAILED)
        /// </summary>
        /// <example>Actor run did not succeed (run ID: 55uatRrZib4xbZs, status: FAILED)</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorRunFailedErrorError" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message">
        /// Example: Actor run did not succeed (run ID: 55uatRrZib4xbZs, status: FAILED)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActorRunFailedErrorError(
            global::Apify.ActorRunFailedErrorErrorType? type,
            string? message)
        {
            this.Type = type;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorRunFailedErrorError" /> class.
        /// </summary>
        public ActorRunFailedErrorError()
        {
        }
    }
}