
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActorDefinitionStorages(
            object? dataset)
        {
            this.Dataset = dataset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorDefinitionStorages" /> class.
        /// </summary>
        public ActorDefinitionStorages()
        {
        }

    }
}