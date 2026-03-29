
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KeyValueStoreKey
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Size { get; set; }

        /// <summary>
        /// A public link to access this record directly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordPublicUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RecordPublicUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyValueStoreKey" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="size"></param>
        /// <param name="recordPublicUrl">
        /// A public link to access this record directly.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeyValueStoreKey(
            string key,
            int size,
            string recordPublicUrl)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Size = size;
            this.RecordPublicUrl = recordPublicUrl ?? throw new global::System.ArgumentNullException(nameof(recordPublicUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyValueStoreKey" /> class.
        /// </summary>
        public KeyValueStoreKey()
        {
        }
    }
}