
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetStats
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
        /// Total storage size in bytes. Only returned by the single-dataset endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storageBytes")]
        public long? StorageBytes { get; set; }

        /// <summary>
        /// Uncompressed size in bytes. Only returned by the dataset list endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inflatedBytes")]
        public long? InflatedBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetStats" /> class.
        /// </summary>
        /// <param name="readCount"></param>
        /// <param name="writeCount"></param>
        /// <param name="storageBytes">
        /// Total storage size in bytes. Only returned by the single-dataset endpoint.
        /// </param>
        /// <param name="inflatedBytes">
        /// Uncompressed size in bytes. Only returned by the dataset list endpoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetStats(
            int? readCount,
            int? writeCount,
            long? storageBytes,
            long? inflatedBytes)
        {
            this.ReadCount = readCount;
            this.WriteCount = writeCount;
            this.StorageBytes = storageBytes;
            this.InflatedBytes = inflatedBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetStats" /> class.
        /// </summary>
        public DatasetStats()
        {
        }

    }
}