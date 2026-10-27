
#nullable enable

namespace Apify
{
    /// <summary>
    /// Optional JSON schema describing the keys stored in the key-value store. Older stores return it as a JSON string.
    /// </summary>
    public sealed partial class KeyValueStoreListItemSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}