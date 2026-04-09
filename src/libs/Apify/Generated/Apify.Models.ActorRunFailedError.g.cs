
#nullable enable

namespace Apify
{
    /// <summary>
    /// Example: {"error":{"type":"run-failed","message":"Actor run did not succeed (run ID: 55uatRrZib4xbZs, status: FAILED)"}}
    /// </summary>
    public sealed partial class ActorRunFailedError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.RunFailedErrorDetailJsonConverter))]
        public global::Apify.RunFailedErrorDetail? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorRunFailedError" /> class.
        /// </summary>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActorRunFailedError(
            global::Apify.RunFailedErrorDetail? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorRunFailedError" /> class.
        /// </summary>
        public ActorRunFailedError()
        {
        }
    }
}