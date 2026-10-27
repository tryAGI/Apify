
#nullable enable

namespace Apify
{
    /// <summary>
    /// Statistics about request queue operations and storage, as returned in request queue lists.
    /// </summary>
    public sealed partial class RequestQueueListStats
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
        /// The total number of write operations performed on the request queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("writeCount")]
        public int? WriteCount { get; set; }

        /// <summary>
        /// The storage size in bytes of requests stored in S3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3StorageBytes")]
        public long? S3StorageBytes { get; set; }

        /// <summary>
        /// The storage size in bytes of requests stored in DynamoDB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamodbStorageBytes")]
        public long? DynamodbStorageBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestQueueListStats" /> class.
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
        /// <param name="writeCount">
        /// The total number of write operations performed on the request queue.
        /// </param>
        /// <param name="s3StorageBytes">
        /// The storage size in bytes of requests stored in S3.
        /// </param>
        /// <param name="dynamodbStorageBytes">
        /// The storage size in bytes of requests stored in DynamoDB.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestQueueListStats(
            int? deleteCount,
            int? headItemReadCount,
            int? readCount,
            int? writeCount,
            long? s3StorageBytes,
            long? dynamodbStorageBytes)
        {
            this.DeleteCount = deleteCount;
            this.HeadItemReadCount = headItemReadCount;
            this.ReadCount = readCount;
            this.WriteCount = writeCount;
            this.S3StorageBytes = s3StorageBytes;
            this.DynamodbStorageBytes = dynamodbStorageBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestQueueListStats" /> class.
        /// </summary>
        public RequestQueueListStats()
        {
        }

    }
}