
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RunUsage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ACTOR_COMPUTE_UNITS")]
        public double? ActorComputeUnits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("DATASET_READS")]
        public int? DatasetReads { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("DATASET_WRITES")]
        public int? DatasetWrites { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("KEY_VALUE_STORE_READS")]
        public int? KeyValueStoreReads { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("KEY_VALUE_STORE_WRITES")]
        public int? KeyValueStoreWrites { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("KEY_VALUE_STORE_LISTS")]
        public int? KeyValueStoreLists { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("REQUEST_QUEUE_READS")]
        public int? RequestQueueReads { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("REQUEST_QUEUE_WRITES")]
        public int? RequestQueueWrites { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("DATA_TRANSFER_INTERNAL_GBYTES")]
        public double? DataTransferInternalGbytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("DATA_TRANSFER_EXTERNAL_GBYTES")]
        public double? DataTransferExternalGbytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("PROXY_RESIDENTIAL_TRANSFER_GBYTES")]
        public double? ProxyResidentialTransferGbytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("PROXY_SERPS")]
        public int? ProxySerps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunUsage" /> class.
        /// </summary>
        /// <param name="actorComputeUnits"></param>
        /// <param name="datasetReads"></param>
        /// <param name="datasetWrites"></param>
        /// <param name="keyValueStoreReads"></param>
        /// <param name="keyValueStoreWrites"></param>
        /// <param name="keyValueStoreLists"></param>
        /// <param name="requestQueueReads"></param>
        /// <param name="requestQueueWrites"></param>
        /// <param name="dataTransferInternalGbytes"></param>
        /// <param name="dataTransferExternalGbytes"></param>
        /// <param name="proxyResidentialTransferGbytes"></param>
        /// <param name="proxySerps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunUsage(
            double? actorComputeUnits,
            int? datasetReads,
            int? datasetWrites,
            int? keyValueStoreReads,
            int? keyValueStoreWrites,
            int? keyValueStoreLists,
            int? requestQueueReads,
            int? requestQueueWrites,
            double? dataTransferInternalGbytes,
            double? dataTransferExternalGbytes,
            double? proxyResidentialTransferGbytes,
            int? proxySerps)
        {
            this.ActorComputeUnits = actorComputeUnits;
            this.DatasetReads = datasetReads;
            this.DatasetWrites = datasetWrites;
            this.KeyValueStoreReads = keyValueStoreReads;
            this.KeyValueStoreWrites = keyValueStoreWrites;
            this.KeyValueStoreLists = keyValueStoreLists;
            this.RequestQueueReads = requestQueueReads;
            this.RequestQueueWrites = requestQueueWrites;
            this.DataTransferInternalGbytes = dataTransferInternalGbytes;
            this.DataTransferExternalGbytes = dataTransferExternalGbytes;
            this.ProxyResidentialTransferGbytes = proxyResidentialTransferGbytes;
            this.ProxySerps = proxySerps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunUsage" /> class.
        /// </summary>
        public RunUsage()
        {
        }

    }
}