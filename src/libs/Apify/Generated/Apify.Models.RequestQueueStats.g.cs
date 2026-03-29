
#nullable enable

namespace Apify
{
    /// <summary>
    /// Statistics about request queue operations and storage.
    /// </summary>
    public sealed partial class RequestQueueStats
    {
        /// <summary>
        /// The number of delete operations performed on the request queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleteCount")]
        public int? DeleteCount { get; set; }

        /// <summary>
        /// The number of times requests from the head were read.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headItemReadCount")]
        public int? HeadItemReadCount { get; set; }

        /// <summary>
        /// The total number of read operations performed on the request queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readCount")]
        public int? ReadCount { get; set; }

        /// <summary>
        /// The total storage size in bytes used by the request queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storageBytes")]
        public long? StorageBytes { get; set; }

        /// <summary>
        /// The total number of write operations performed on the request queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("writeCount")]
        public int? WriteCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestQueueStats" /> class.
        /// </summary>
        /// <param name="deleteCount">
        /// The number of delete operations performed on the request queue.
        /// </param>
        /// <param name="headItemReadCount">
        /// The number of times requests from the head were read.
        /// </param>
        /// <param name="readCount">
        /// The total number of read operations performed on the request queue.
        /// </param>
        /// <param name="storageBytes">
        /// The total storage size in bytes used by the request queue.
        /// </param>
        /// <param name="writeCount">
        /// The total number of write operations performed on the request queue.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestQueueStats(
            int? deleteCount,
            int? headItemReadCount,
            int? readCount,
            long? storageBytes,
            int? writeCount)
        {
            this.DeleteCount = deleteCount;
            this.HeadItemReadCount = headItemReadCount;
            this.ReadCount = readCount;
            this.StorageBytes = storageBytes;
            this.WriteCount = writeCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestQueueStats" /> class.
        /// </summary>
        public RequestQueueStats()
        {
        }
    }
}