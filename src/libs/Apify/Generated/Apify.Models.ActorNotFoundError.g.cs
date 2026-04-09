
#nullable enable

namespace Apify
{
    /// <summary>
    /// Example: {"error":{"type":"actor-not-found","message":"Actor was not found"}}
    /// </summary>
    public sealed partial class ActorNotFoundError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.ActorNotFoundErrorDetailJsonConverter))]
        public global::Apify.ActorNotFoundErrorDetail? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorNotFoundError" /> class.
        /// </summary>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActorNotFoundError(
            global::Apify.ActorNotFoundErrorDetail? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorNotFoundError" /> class.
        /// </summary>
        public ActorNotFoundError()
        {
        }
    }
}