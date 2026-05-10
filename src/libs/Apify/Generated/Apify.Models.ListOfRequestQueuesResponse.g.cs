
#nullable enable

namespace Apify
{
    /// <summary>
    /// Response containing a list of request queues.
    /// </summary>
    public sealed partial class ListOfRequestQueuesResponse
    {
        /// <summary>
        /// A paginated list of request queues.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.ListOfRequestQueuesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.ListOfRequestQueues Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfRequestQueuesResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A paginated list of request queues.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListOfRequestQueuesResponse(
            global::Apify.ListOfRequestQueues data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfRequestQueuesResponse" /> class.
        /// </summary>
        public ListOfRequestQueuesResponse()
        {
        }

    }
}