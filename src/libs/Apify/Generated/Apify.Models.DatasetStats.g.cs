
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReadCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("writeCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WriteCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storageBytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long StorageBytes { get; set; }

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
        /// <param name="storageBytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetStats(
            int readCount,
            int writeCount,
            long storageBytes)
        {
            this.ReadCount = readCount;
            this.WriteCount = writeCount;
            this.StorageBytes = storageBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetStats" /> class.
        /// </summary>
        public DatasetStats()
        {
        }

    }
}