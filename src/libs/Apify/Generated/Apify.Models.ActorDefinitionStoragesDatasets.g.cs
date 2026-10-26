
#nullable enable

namespace Apify
{
    /// <summary>
    /// Maps dataset aliases to the schemas of the Actor's datasets, the full specification can be found in [Apify docs](https://docs.apify.com/platform/storage/dataset-schema/multiple-datasets)
    /// </summary>
    public sealed partial class ActorDefinitionStoragesDatasets
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}