
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListOfWebhookDispatchesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.ListOfWebhookDispatchesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.ListOfWebhookDispatches Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfWebhookDispatchesResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListOfWebhookDispatchesResponse(
            global::Apify.ListOfWebhookDispatches data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfWebhookDispatchesResponse" /> class.
        /// </summary>
        public ListOfWebhookDispatchesResponse()
        {
        }
    }
}