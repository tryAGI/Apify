
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListOfKeys
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Apify.KeyValueStoreKey> Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclusiveStartKey")]
        public string? ExclusiveStartKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isTruncated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsTruncated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextExclusiveStartKey")]
        public string? NextExclusiveStartKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfKeys" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="count"></param>
        /// <param name="limit"></param>
        /// <param name="isTruncated"></param>
        /// <param name="exclusiveStartKey"></param>
        /// <param name="nextExclusiveStartKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListOfKeys(
            global::System.Collections.Generic.IList<global::Apify.KeyValueStoreKey> items,
            int count,
            int limit,
            bool isTruncated,
            string? exclusiveStartKey,
            string? nextExclusiveStartKey)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Count = count;
            this.Limit = limit;
            this.ExclusiveStartKey = exclusiveStartKey;
            this.IsTruncated = isTruncated;
            this.NextExclusiveStartKey = nextExclusiveStartKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfKeys" /> class.
        /// </summary>
        public ListOfKeys()
        {
        }

    }
}