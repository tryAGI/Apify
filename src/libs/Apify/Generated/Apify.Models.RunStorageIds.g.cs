
#nullable enable

namespace Apify
{
    /// <summary>
    /// A map of aliased storage IDs associated with this run, grouped by storage type.
    /// </summary>
    public sealed partial class RunStorageIds
    {
        /// <summary>
        /// Aliased dataset IDs for this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasets")]
        public global::Apify.RunStorageIdsDatasets? Datasets { get; set; }

        /// <summary>
        /// Aliased key-value store IDs for this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyValueStores")]
        public global::Apify.RunStorageIdsKeyValueStores? KeyValueStores { get; set; }

        /// <summary>
        /// Aliased request queue IDs for this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestQueues")]
        public global::Apify.RunStorageIdsRequestQueues? RequestQueues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStorageIds" /> class.
        /// </summary>
        /// <param name="datasets">
        /// Aliased dataset IDs for this run.
        /// </param>
        /// <param name="keyValueStores">
        /// Aliased key-value store IDs for this run.
        /// </param>
        /// <param name="requestQueues">
        /// Aliased request queue IDs for this run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunStorageIds(
            global::Apify.RunStorageIdsDatasets? datasets,
            global::Apify.RunStorageIdsKeyValueStores? keyValueStores,
            global::Apify.RunStorageIdsRequestQueues? requestQueues)
        {
            this.Datasets = datasets;
            this.KeyValueStores = keyValueStores;
            this.RequestQueues = requestQueues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStorageIds" /> class.
        /// </summary>
        public RunStorageIds()
        {
        }
    }
}