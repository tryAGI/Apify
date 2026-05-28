
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListOfKeyValueStoresVariant2
    {
        /// <summary>
        /// Whether the listing was filtered to only unnamed key-value stores.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unnamed")]
        public bool? Unnamed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Apify.KeyValueStore> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfKeyValueStoresVariant2" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="unnamed">
        /// Whether the listing was filtered to only unnamed key-value stores.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListOfKeyValueStoresVariant2(
            global::System.Collections.Generic.IList<global::Apify.KeyValueStore> items,
            bool? unnamed)
        {
            this.Unnamed = unnamed;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfKeyValueStoresVariant2" /> class.
        /// </summary>
        public ListOfKeyValueStoresVariant2()
        {
        }

    }
}