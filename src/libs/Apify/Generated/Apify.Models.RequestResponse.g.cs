
#nullable enable

namespace Apify
{
    /// <summary>
    /// Response containing a single request from the request queue.
    /// </summary>
    public sealed partial class RequestResponse
    {
        /// <summary>
        /// A request stored in the request queue, including its metadata and processing state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.RequestJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.Request Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A request stored in the request queue, including its metadata and processing state.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestResponse(
            global::Apify.Request data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestResponse" /> class.
        /// </summary>
        public RequestResponse()
        {
        }
    }
}