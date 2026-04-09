
#nullable enable

namespace Apify
{
    /// <summary>
    /// Example: {"error":{"type":"run-timeout-exceeded","message":"Actor run exceeded the timeout of 300 seconds for this API endpoint"}}
    /// </summary>
    public sealed partial class ActorRunTimeoutExceededError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.RunTimeoutExceededErrorDetailJsonConverter))]
        public global::Apify.RunTimeoutExceededErrorDetail? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorRunTimeoutExceededError" /> class.
        /// </summary>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActorRunTimeoutExceededError(
            global::Apify.RunTimeoutExceededErrorDetail? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorRunTimeoutExceededError" /> class.
        /// </summary>
        public ActorRunTimeoutExceededError()
        {
        }
    }
}