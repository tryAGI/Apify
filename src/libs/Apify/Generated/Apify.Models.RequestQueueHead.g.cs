
#nullable enable

namespace Apify
{
    /// <summary>
    /// A batch of requests from the request queue head without locking.
    /// </summary>
    public sealed partial class RequestQueueHead
    {
        /// <summary>
        /// The maximum number of requests returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// The timestamp when the request queue was last modified. Modifications include adding, updating, or removing requests, as well as locking or unlocking requests in the request queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queueModifiedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime QueueModifiedAt { get; set; }

        /// <summary>
        /// Whether the request queue has been accessed by multiple different clients.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hadMultipleClients")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HadMultipleClients { get; set; }

        /// <summary>
        /// The array of requests from the request queue head.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Apify.HeadRequest> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestQueueHead" /> class.
        /// </summary>
        /// <param name="limit">
        /// The maximum number of requests returned.
        /// </param>
        /// <param name="queueModifiedAt">
        /// The timestamp when the request queue was last modified. Modifications include adding, updating, or removing requests, as well as locking or unlocking requests in the request queue.
        /// </param>
        /// <param name="hadMultipleClients">
        /// Whether the request queue has been accessed by multiple different clients.
        /// </param>
        /// <param name="items">
        /// The array of requests from the request queue head.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestQueueHead(
            int limit,
            global::System.DateTime queueModifiedAt,
            bool hadMultipleClients,
            global::System.Collections.Generic.IList<global::Apify.HeadRequest> items)
        {
            this.Limit = limit;
            this.QueueModifiedAt = queueModifiedAt;
            this.HadMultipleClients = hadMultipleClients;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestQueueHead" /> class.
        /// </summary>
        public RequestQueueHead()
        {
        }
    }
}