
#nullable enable

namespace Apify
{
    /// <summary>
    /// Defines the schema of items in your dataset, the full specification can be found in [Apify docs](https://docs.apify.com/platform/actors/development/actor-definition/dataset-schema)
    /// </summary>
    public sealed partial class ActorDefinitionStoragesDataset
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}