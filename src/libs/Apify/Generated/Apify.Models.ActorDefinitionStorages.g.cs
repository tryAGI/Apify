
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ActorDefinitionStorages
    {
        /// <summary>
        /// Defines the schema of items in your dataset, the full specification can be found in [Apify docs](https://docs.apify.com/platform/actors/development/actor-definition/dataset-schema)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        public object? Dataset { get; set; }

        /// <summary>
        /// Maps dataset aliases to the schemas of the Actor's datasets, the full specification can be found in [Apify docs](https://docs.apify.com/platform/storage/dataset-schema/multiple-datasets)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasets")]
        public global::System.Collections.Generic.Dictionary<string, object>? Datasets { get; set; }

        /// <summary>
        /// Defines the schema of the Actor's default key-value store, the full specification can be found in [Apify docs](https://docs.apify.com/platform/storage/key-value-store-schema)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyValueStore")]
        public object? KeyValueStore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorDefinitionStorages" /> class.
        /// </summary>
        /// <param name="dataset">
        /// Defines the schema of items in your dataset, the full specification can be found in [Apify docs](https://docs.apify.com/platform/actors/development/actor-definition/dataset-schema)
        /// </param>
        /// <param name="datasets">
        /// Maps dataset aliases to the schemas of the Actor's datasets, the full specification can be found in [Apify docs](https://docs.apify.com/platform/storage/dataset-schema/multiple-datasets)
        /// </param>
        /// <param name="keyValueStore">
        /// Defines the schema of the Actor's default key-value store, the full specification can be found in [Apify docs](https://docs.apify.com/platform/storage/key-value-store-schema)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActorDefinitionStorages(
            object? dataset,
            global::System.Collections.Generic.Dictionary<string, object>? datasets,
            object? keyValueStore)
        {
            this.Dataset = dataset;
            this.Datasets = datasets;
            this.KeyValueStore = keyValueStore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorDefinitionStorages" /> class.
        /// </summary>
        public ActorDefinitionStorages()
        {
        }

    }
}