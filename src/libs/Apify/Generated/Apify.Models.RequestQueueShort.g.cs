
#nullable enable

namespace Apify
{
    /// <summary>
    /// A shortened request queue object for list responses.
    /// </summary>
    public sealed partial class RequestQueueShort
    {
        /// <summary>
        /// A unique identifier assigned to the request queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the request queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The ID of the user who owns the request queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The username of the user who owns the request queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// The timestamp when the request queue was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The timestamp when the request queue was last modified. Modifications include adding, updating, or removing requests, as well as locking or unlocking requests in the request queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modifiedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ModifiedAt { get; set; }

        /// <summary>
        /// The timestamp when the request queue was last accessed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime AccessedAt { get; set; }

        /// <summary>
        /// The timestamp when the request queue will expire and be deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expireAt")]
        public global::System.DateTime? ExpireAt { get; set; }

        /// <summary>
        /// The total number of requests in the request queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalRequestCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalRequestCount { get; set; }

        /// <summary>
        /// The number of requests that have been handled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handledRequestCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int HandledRequestCount { get; set; }

        /// <summary>
        /// The number of requests that are pending and have not been handled yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pendingRequestCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PendingRequestCount { get; set; }

        /// <summary>
        /// The ID of the Actor that created this request queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actId")]
        public string? ActId { get; set; }

        /// <summary>
        /// The ID of the Actor run that created this request queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actRunId")]
        public string? ActRunId { get; set; }

        /// <summary>
        /// Whether the request queue has been accessed by multiple different clients.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hadMultipleClients")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HadMultipleClients { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestQueueShort" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier assigned to the request queue.
        /// </param>
        /// <param name="name">
        /// The name of the request queue.
        /// </param>
        /// <param name="userId">
        /// The ID of the user who owns the request queue.
        /// </param>
        /// <param name="username">
        /// The username of the user who owns the request queue.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the request queue was created.
        /// </param>
        /// <param name="modifiedAt">
        /// The timestamp when the request queue was last modified. Modifications include adding, updating, or removing requests, as well as locking or unlocking requests in the request queue.
        /// </param>
        /// <param name="accessedAt">
        /// The timestamp when the request queue was last accessed.
        /// </param>
        /// <param name="totalRequestCount">
        /// The total number of requests in the request queue.
        /// </param>
        /// <param name="handledRequestCount">
        /// The number of requests that have been handled.
        /// </param>
        /// <param name="pendingRequestCount">
        /// The number of requests that are pending and have not been handled yet.
        /// </param>
        /// <param name="hadMultipleClients">
        /// Whether the request queue has been accessed by multiple different clients.
        /// </param>
        /// <param name="expireAt">
        /// The timestamp when the request queue will expire and be deleted.
        /// </param>
        /// <param name="actId">
        /// The ID of the Actor that created this request queue.
        /// </param>
        /// <param name="actRunId">
        /// The ID of the Actor run that created this request queue.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestQueueShort(
            string id,
            string name,
            string userId,
            string username,
            global::System.DateTime createdAt,
            global::System.DateTime modifiedAt,
            global::System.DateTime accessedAt,
            int totalRequestCount,
            int handledRequestCount,
            int pendingRequestCount,
            bool hadMultipleClients,
            global::System.DateTime? expireAt,
            string? actId,
            string? actRunId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.AccessedAt = accessedAt;
            this.ExpireAt = expireAt;
            this.TotalRequestCount = totalRequestCount;
            this.HandledRequestCount = handledRequestCount;
            this.PendingRequestCount = pendingRequestCount;
            this.ActId = actId;
            this.ActRunId = actRunId;
            this.HadMultipleClients = hadMultipleClients;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestQueueShort" /> class.
        /// </summary>
        public RequestQueueShort()
        {
        }

    }
}