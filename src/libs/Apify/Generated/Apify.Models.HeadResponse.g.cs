
#nullable enable

namespace Apify
{
    /// <summary>
    /// Response containing requests from the request queue head without locking.<br/>
    /// Example: {"data":{"limit":1000,"queueModifiedAt":"2018-03-14T23:00:00.000Z","hadMultipleClients":false,"items":[{"id":"8OamqXBCpPHxyH9","retryCount":0,"uniqueKey":"http://example.com","url":"http://example.com","method":"GET"},{"id":"ZJAoqlRijenMQIn","retryCount":0,"uniqueKey":"http://example.com/a/b","url":"http://example.com/a/b","method":"GET"},{"id":"hAhkwyk5oOBHKQC","retryCount":1,"uniqueKey":"http://example.com/c/d","url":"http://example.com/c/d","method":"GET"}]}}
    /// </summary>
    public sealed partial class HeadResponse
    {
        /// <summary>
        /// A batch of requests from the request queue head without locking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.RequestQueueHead Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeadResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A batch of requests from the request queue head without locking.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeadResponse(
            global::Apify.RequestQueueHead data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeadResponse" /> class.
        /// </summary>
        public HeadResponse()
        {
        }
    }
}