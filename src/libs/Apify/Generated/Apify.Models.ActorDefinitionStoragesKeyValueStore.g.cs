
#nullable enable

namespace Apify
{
    /// <summary>
    /// Defines the schema of the Actor's default key-value store, the full specification can be found in [Apify docs](https://docs.apify.com/platform/storage/key-value-store-schema)
    /// </summary>
    public sealed partial class ActorDefinitionStoragesKeyValueStore
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}