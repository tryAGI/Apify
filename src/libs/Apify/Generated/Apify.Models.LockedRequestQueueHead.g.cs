
#nullable enable

namespace Apify
{
    /// <summary>
    /// A batch of locked requests from the request queue head.
    /// </summary>
    public sealed partial class LockedRequestQueueHead
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
        /// Whether the request queue contains requests locked by any client (either the one calling the endpoint or a different one).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queueHasLockedRequests")]
        public bool? QueueHasLockedRequests { get; set; }

        /// <summary>
        /// The client key used for locking the requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientKey")]
        public string? ClientKey { get; set; }

        /// <summary>
        /// Whether the request queue has been accessed by multiple different clients.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hadMultipleClients")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HadMultipleClients { get; set; }

        /// <summary>
        /// The number of seconds the locks will be held.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lockSecs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LockSecs { get; set; }

        /// <summary>
        /// The array of locked requests from the request queue head.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Apify.LockedHeadRequest> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LockedRequestQueueHead" /> class.
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
        /// <param name="lockSecs">
        /// The number of seconds the locks will be held.
        /// </param>
        /// <param name="items">
        /// The array of locked requests from the request queue head.
        /// </param>
        /// <param name="queueHasLockedRequests">
        /// Whether the request queue contains requests locked by any client (either the one calling the endpoint or a different one).
        /// </param>
        /// <param name="clientKey">
        /// The client key used for locking the requests.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LockedRequestQueueHead(
            int limit,
            global::System.DateTime queueModifiedAt,
            bool hadMultipleClients,
            int lockSecs,
            global::System.Collections.Generic.IList<global::Apify.LockedHeadRequest> items,
            bool? queueHasLockedRequests,
            string? clientKey)
        {
            this.Limit = limit;
            this.QueueModifiedAt = queueModifiedAt;
            this.QueueHasLockedRequests = queueHasLockedRequests;
            this.ClientKey = clientKey;
            this.HadMultipleClients = hadMultipleClients;
            this.LockSecs = lockSecs;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LockedRequestQueueHead" /> class.
        /// </summary>
        public LockedRequestQueueHead()
        {
        }

    }
}