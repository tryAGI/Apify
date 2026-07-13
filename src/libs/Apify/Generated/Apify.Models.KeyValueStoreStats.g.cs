
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KeyValueStoreStats
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readCount")]
        public int? ReadCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("writeCount")]
        public int? WriteCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleteCount")]
        public int? DeleteCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("listCount")]
        public int? ListCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3StorageBytes")]
        public long? S3StorageBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storageBytes")]
        public long? StorageBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyValueStoreStats" /> class.
        /// </summary>
        /// <param name="readCount"></param>
        /// <param name="writeCount"></param>
        /// <param name="deleteCount"></param>
        /// <param name="listCount"></param>
        /// <param name="s3StorageBytes"></param>
        /// <param name="storageBytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeyValueStoreStats(
            int? readCount,
            int? writeCount,
            int? deleteCount,
            int? listCount,
            long? s3StorageBytes,
            long? storageBytes)
        {
            this.ReadCount = readCount;
            this.WriteCount = writeCount;
            this.DeleteCount = deleteCount;
            this.ListCount = listCount;
            this.S3StorageBytes = s3StorageBytes;
            this.StorageBytes = storageBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyValueStoreStats" /> class.
        /// </summary>
        public KeyValueStoreStats()
        {
        }

    }
}