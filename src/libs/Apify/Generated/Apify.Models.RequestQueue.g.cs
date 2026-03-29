
#nullable enable

namespace Apify
{
    /// <summary>
    /// A request queue object containing metadata and statistics.
    /// </summary>
    public sealed partial class RequestQueue
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
        public string? Name { get; set; }

        /// <summary>
        /// The ID of the user who owns the request queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

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
        /// Whether the request queue has been accessed by multiple different clients.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hadMultipleClients")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HadMultipleClients { get; set; }

        /// <summary>
        /// The URL to view the request queue in the Apify console.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consoleUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConsoleUrl { get; set; }

        /// <summary>
        /// Statistics about request queue operations and storage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        public global::Apify.RequestQueueStats? Stats { get; set; }

        /// <summary>
        /// Defines the general access level for the resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generalAccess")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.GeneralAccessJsonConverter))]
        public global::Apify.GeneralAccess? GeneralAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestQueue" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier assigned to the request queue.
        /// </param>
        /// <param name="userId">
        /// The ID of the user who owns the request queue.
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
        /// <param name="consoleUrl">
        /// The URL to view the request queue in the Apify console.
        /// </param>
        /// <param name="name">
        /// The name of the request queue.
        /// </param>
        /// <param name="stats">
        /// Statistics about request queue operations and storage.
        /// </param>
        /// <param name="generalAccess">
        /// Defines the general access level for the resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestQueue(
            string id,
            string userId,
            global::System.DateTime createdAt,
            global::System.DateTime modifiedAt,
            global::System.DateTime accessedAt,
            int totalRequestCount,
            int handledRequestCount,
            int pendingRequestCount,
            bool hadMultipleClients,
            string consoleUrl,
            string? name,
            global::Apify.RequestQueueStats? stats,
            global::Apify.GeneralAccess? generalAccess)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.AccessedAt = accessedAt;
            this.TotalRequestCount = totalRequestCount;
            this.HandledRequestCount = handledRequestCount;
            this.PendingRequestCount = pendingRequestCount;
            this.HadMultipleClients = hadMultipleClients;
            this.ConsoleUrl = consoleUrl ?? throw new global::System.ArgumentNullException(nameof(consoleUrl));
            this.Stats = stats;
            this.GeneralAccess = generalAccess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestQueue" /> class.
        /// </summary>
        public RequestQueue()
        {
        }
    }
}